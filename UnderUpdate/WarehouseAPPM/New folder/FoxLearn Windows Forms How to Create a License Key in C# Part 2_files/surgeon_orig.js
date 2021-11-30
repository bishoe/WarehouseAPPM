function xhrSuccess(){this.callback.apply(this,this.arguments);}
function xhrError(){console.error(this.statusText);}
function loadFile(url,callback){var xhr=new XMLHttpRequest();xhr.callback=callback;xhr.arguments=Array.prototype.slice.call(arguments,2);xhr.onload=xhrSuccess;xhr.onerror=xhrError;xhr.open("GET",url,true);xhr.send(null);}
function lex(css){var buffer="";var ch;var column=0;var cursor=-1;var depth=0;var line=1;var state="before-selector";var stack=[state];var token={};var tokens=[];var skipReset=false;var atRules=["media","keyframes",{name:"-webkit-keyframes",type:"keyframes",prefix:"-webkit-"},{name:"-moz-keyframes",type:"keyframes",prefix:"-moz-"},{name:"-ms-keyframes",type:"keyframes",prefix:"-ms-"},{name:"-o-keyframes",type:"keyframes",prefix:"-o-"},"font-face",{name:"import",state:"before-at-value"},{name:"charset",state:"before-at-value"},"supports","viewport",{name:"namespace",state:"before-at-value"},"document",{name:"-moz-document",type:"document",prefix:"-moz-"},"page"];function getCh(){skip();return css[cursor];}
function getState(index){return index?stack[stack.length-1-index]:state;}
function resetState(){state="before-selector";stack=[state];}
function isNextString(str){var start=cursor+1;return str===css.slice(start,start+str.length);}
function find(str){var pos=css.slice(cursor).indexOf(str);return pos>0?pos:false;}
function isNextChar(ch){return ch===peek(1);}
function peek(offset){return css[cursor+(offset||1)];}
function popState(){var removed=stack.pop();state=stack[stack.length-1];return removed;}
function pushState(newState){state=newState;stack.push(state);return stack.length;}
function replaceState(newState){var previousState=state;stack[stack.length-1]=state=newState;return previousState;}
function skip(n){if((n||1)==1){if(css[cursor]=="\n"){line++;column=1;}else{column++;}
cursor++;}else{var skipStr=css.slice(cursor,cursor+n).split("\n");if(skipStr.length>1){line+=skipStr.length-1;column=1;}
column+=skipStr[skipStr.length-1].length;cursor=cursor+n;}}
function addToken(){token.end={line:line,col:column};tokens.push(token);buffer="";token={};}
function initializeToken(type){token={type:type,start:{line:line,col:column}};}
while((ch=getCh())){switch(ch){case " ":switch(getState()){case "selector":case "value":case "value-paren":case "at-group":case "at-value":case "comment":case "double-string":case "single-string":buffer+=ch;break;}
break;case "\n":case "\t":case "\r":case "\f":switch(getState()){case "value":case "value-paren":case "at-group":case "comment":case "single-string":case "double-string":case "selector":buffer+=ch;break;case "at-value":if("\n"===ch){token.value=buffer.trim();addToken();popState();}
break;}
break;case ":":switch(getState()){case "name":token.name=buffer.trim();buffer="";replaceState("before-value");break;case "before-selector":buffer+=ch;initializeToken("selector");pushState("selector");break;case "before-value":replaceState("value");buffer+=ch;break;default:buffer+=ch;break;}
break;case ";":switch(getState()){case "name":case "before-value":case "value":if(buffer.trim().length>0){(token.value=buffer.trim()),addToken();}
replaceState("before-name");break;case "value-paren":buffer+=ch;break;case "at-value":token.value=buffer.trim();addToken();popState();break;case "before-name":break;default:buffer+=ch;break;}
break;case "{":switch(getState()){case "selector":if(peek(-1)==="\\"){buffer+=ch;break;}
token.text=buffer.trim();addToken();replaceState("before-name");depth=depth+1;break;case "at-group":token.name=buffer.trim();switch(token.type){case "font-face":case "viewport":case "page":pushState("before-name");break;default:pushState("before-selector");}
addToken();depth=depth+1;break;case "name":case "at-rule":token.name=buffer.trim();addToken();pushState("before-name");depth=depth+1;break;case "comment":case "double-string":case "single-string":buffer+=ch;break;case "before-value":replaceState("value");buffer+=ch;break;}
break;case "}":switch(getState()){case "before-name":case "name":case "before-value":case "value":if(buffer){token.value=buffer.trim();}
if(token.name&&token.value){addToken();}
initializeToken("end");addToken();popState();if("at-group"===getState()){initializeToken("at-group-end");addToken();popState();}
if(depth>0){depth=depth-1;}
break;case "at-group":case "before-selector":case "selector":if(peek(-1)==="\\"){buffer+=ch;break;}
if(depth>0){if("at-group"===getState(1)){initializeToken("at-group-end");addToken();if(getState()=="before-selector"&&depth>1){popState();}}}
if(depth>1){popState();}
if(depth>0){depth=depth-1;}
break;case "double-string":case "single-string":case "comment":buffer+=ch;skipReset=true;break;}
if(depth==0&&skipReset==false){resetState();}else{skipReset=false;}
break;case '"':case "'":switch(getState()){case "double-string":if('"'===ch&&"\\"!==peek(-1)){popState();}
break;case "single-string":if("'"===ch&&"\\"!==peek(-1)){popState();}
break;case "before-at-value":replaceState("at-value");pushState('"'===ch?"double-string":"single-string");break;case "before-value":replaceState("value");pushState('"'===ch?"double-string":"single-string");break;case "comment":break;default:if("\\"!==peek(-1)){pushState('"'===ch?"double-string":"single-string");}}
buffer+=ch;break;case "/":switch(getState()){case "comment":case "double-string":case "single-string":buffer+=ch;break;case "before-value":case "selector":case "name":case "value":if(isNextChar("*")){var pos=find("*/");if(pos){skip(pos+1);}}else{if(getState()=="before-value")
replaceState("value");buffer+=ch;}
break;default:if(isNextChar("*")){initializeToken("comment");pushState("comment");skip();}else{buffer+=ch;}
break;}
break;case "*":switch(getState()){case "comment":if(isNextChar("/")){token.text=buffer;skip();addToken();popState();}else{buffer+=ch;}
break;case "before-selector":buffer+=ch;initializeToken("selector");pushState("selector");break;case "before-value":replaceState("value");buffer+=ch;break;default:buffer+=ch;}
break;case "@":switch(getState()){case "comment":case "double-string":case "single-string":buffer+=ch;break;case "before-value":replaceState("value");buffer+=ch;break;default:var tokenized=false;var name;var rule;for(var j=0,len=atRules.length;!tokenized&&j<len;++j){rule=atRules[j];name=rule.name||rule;if(!isNextString(name)){continue;}
tokenized=true;initializeToken(name);pushState(rule.state||"at-group");skip(name.length);if(rule.prefix){token.prefix=rule.prefix;}
if(rule.type){token.type=rule.type;}}
if(!tokenized){buffer+=ch;}
break;}
break;case "(":switch(getState()){case "value":pushState("value-paren");break;case "before-value":replaceState("value");break;}
buffer+=ch;break;case ")":switch(getState()){case "value-paren":popState();break;case "before-value":replaceState("value");break;}
buffer+=ch;break;default:switch(getState()){case "before-selector":initializeToken("selector");pushState("selector");break;case "before-name":initializeToken("property");replaceState("name");break;case "before-value":replaceState("value");break;case "before-at-value":replaceState("at-value");break;}
buffer+=ch;break;}}
return tokens;}
var _comments;var _depth;var _position;var _tokens;function parse(css,options){options||(options={});_comments=!!options.comments;_position=!!options.position;_depth=0;_tokens=Array.isArray(css)?css.slice():lex(css);var rule;var rules=[];var token;while((token=next())){rule=parseToken(token);if(rule!=undefined){rules.push(rule);}}
return{type:"stylesheet",stylesheet:{rules:rules}};}
function astNode(token,override){override||(override={});var key;var keys=["type","name","value"];var node={};for(var i=0;i<keys.length;++i){key=keys[i];if(token[key]){node[key]=override[key]||token[key];}}
keys=Object.keys(override);for(i=0;i<keys.length;++i){key=keys[i];if(!node[key]){node[key]=override[key];}}
if(_position){node.position={start:token.start,end:token.end};}
return node;}
function next(){var token=_tokens.shift();return token;}
function parseAtGroup(token){_depth=_depth+1;var overrides={};switch(token.type){case "font-face":case "viewport":overrides.declarations=parseDeclarations();break;case "page":overrides.prefix=token.prefix;overrides.declarations=parseDeclarations();break;default:overrides.prefix=token.prefix;overrides.rules=parseRules();}
return astNode(token,overrides);}
function parseAtImport(token){return astNode(token);}
function parseCharset(token){return astNode(token);}
function parseComment(token){return astNode(token,{text:token.text});}
function parseNamespace(token){return astNode(token);}
function parseProperty(token){return astNode(token);}
function parseSelector(token){function trim(str){return str.trim();}
return astNode(token,{type:"rule",selectors:token.text.split(",").map(trim),declarations:parseDeclarations(token)});}
function parseToken(token){switch(token.type){case "property":return parseProperty(token);case "selector":return parseSelector(token);case "at-group-end":_depth=_depth-1;return;case "media":case "keyframes":return parseAtGroup(token);case "comment":if(_comments){return parseComment(token);}
break;case "charset":return parseCharset(token);case "import":return parseAtImport(token);case "namespace":return parseNamespace(token);case "font-face":case "supports":case "viewport":case "document":case "page":return parseAtGroup(token);}}
function parseTokensWhile(conditionFn){var node;var nodes=[];var token;while((token=next())&&(conditionFn&&conditionFn(token))){node=parseToken(token);node&&nodes.push(node);}
if(token&&token.type!=="end"){_tokens.unshift(token);}
return nodes;}
function parseDeclarations(){return parseTokensWhile(function(token){return token.type==="property"||token.type==="comment";});}
function parseRules(){return parseTokensWhile(function(){return _depth;});}
var _compress;var _indentation;var _level;var _n;var _s;function stringify(ast,options){options||(options={});_indentation=options.indentation||"";_compress=!!options.compress;_comments=!!options.comments;_level=1;if(_compress){_n=_s="";}else{_n="\n";_s=" ";}
var css=reduce(ast.stylesheet.rules,stringifyNode).join("\n").trim();return css;}
function indent(level){if(level){_level+=level;return;}
if(_compress){return "";}
return Array(_level).join(_indentation||"");}
function stringifyAtRule(node){return "@"+node.type+" "+node.value+";"+_n;}
function stringifyAtGroup(node){var label="";var prefix=node.prefix||"";if(node.name){label=" "+node.name;}
var chomp=node.type!=="page";return("@"+prefix+node.type+label+_s+stringifyBlock(node,chomp)+_n);}
function stringifyComment(node){if(!_comments){return "";}
return "/*"+(node.text||"")+"*/"+_n;}
function stringifyRule(node){var label;if(node.selectors){label=node.selectors.join(","+_n);}else{label="@"+node.type;label+=node.name?" "+node.name:"";}
return indent()+label+_s+stringifyBlock(node)+_n;}
function reduce(items,fn){return items.reduce(function(results,item){var result=item.type==="comment"?stringifyComment(item):fn(item);result&&results.push(result);return results;},[]);}
function stringifyBlock(node,chomp){var children=node.declarations;var fn=stringifyDeclaration;if(node.rules){children=node.rules;fn=stringifyRule;}
children=stringifyChildren(children,fn);children&&(children=_n+children+(chomp?"":_n));return "{"+children+indent()+"}";}
function stringifyChildren(children,fn){if(!children){return "";}
indent(1);var results=reduce(children,fn);indent(-1);if(!results.length){return "";}
return results.join(_n);}
function stringifyDeclaration(node){if(node.type==="property"){return stringifyProperty(node);}}
function stringifyNode(node){switch(node.type){case "rule":return stringifyRule(node);case "media":case "keyframes":return stringifyAtGroup(node);case "comment":return stringifyComment(node);case "import":case "charset":case "namespace":return stringifyAtRule(node);case "font-face":case "supports":case "viewport":case "document":case "page":return stringifyAtGroup(node);}}
function stringifyProperty(node){var name=node.name?node.name+":"+_s:"";return indent()+name+node.value+";";}
var CSSurgeon=function(){var api={},elements=false,args=arguments;var requirements=function(){if(args.length===0){throw new Error("CSSSteal expects at least one argument (DOM element)");}
if(!document.styleSheets){throw new Error("CSSSteal: document.styleSheets is not available in this browser.");}
elements=toArray(args,true);};var toArray=function(obj,ignoreFalsy){var arr=[],i;for(i=0;i<obj.length;i++){if(!ignoreFalsy||obj[i]){arr[i]=obj[i];}}
return arr;};var matchOrigRuleToElements=function(rule,els){var selectorText=rule.selectors.reduce(function(accumulator,currentValue){return accumulator+","+currentValue;});selectorText=selectorText.replaceAll("::before","");selectorText=selectorText.replaceAll("::after","");selectorText=selectorText.replaceAll(":before","");selectorText=selectorText.replaceAll(":after","");selectorText=selectorText.replaceAll(":focus","");selectorText=selectorText.replaceAll(":hover","");selectorText=selectorText.replaceAll(":active","");selectorText=selectorText.replaceAll(":checked","");selectorText=selectorText.replaceAll(":invalid","");selectorText=selectorText.replaceAll(":valid","");selectorText=selectorText.replaceAll(":visited","");if(selectorText==""||selectorText.includes(",,")){return rule;}
if(els.length<=0){return null;}
var elsQueue=[...els];while(elsQueue.length>0){try{var el=elsQueue.shift();if(el.matches(selectorText)){return rule;}
if(el.children.length>0){elsQueue.push(...el.children);}}catch(e){}}
return null;};requirements();api.getUsedCSSForOrigStyleSheet=function(styleSheet){if(styleSheet.stylesheet){var matchedRules=[];for(var i in styleSheet.stylesheet.rules){if(styleSheet.stylesheet.rules[i].type==="rule"){var matchedRule=matchOrigRuleToElements(styleSheet.stylesheet.rules[i],elements);if(matchedRule!=null){matchedRules.push(matchedRule);}}else if(styleSheet.stylesheet.rules[i].type==="media"){var mediaRulesMatched=[];for(var j in styleSheet.stylesheet.rules[i].rules){if(styleSheet.stylesheet.rules[i].rules[j].type==="rule"){matchedRule=matchOrigRuleToElements(styleSheet.stylesheet.rules[i].rules[j],elements);if(matchedRule!=null){mediaRulesMatched.push(matchedRule);}}}
if(mediaRulesMatched.length>0){styleSheet.stylesheet.rules[i].rules=mediaRulesMatched;matchedRules.push(styleSheet.stylesheet.rules[i]);}}else if(styleSheet.stylesheet.rules[i].type==="font-face"){matchedRules.push(styleSheet.stylesheet.rules[i]);}}}
var newStyleSheet={stylesheet:{rules:matchedRules}};return stringify(newStyleSheet,null);};return api;};var surgeon=CSSurgeon(document.querySelector("html"));function eachAsync(arr,func,cb){var doneCounter=0,results=[];arr.forEach(function(item){func(item,function(){doneCounter+=1;results[item]=this.responseText;if(doneCounter===arr.length){cb(results);}});});}
function getRandomInt(max){return Math.floor(Math.random()*Math.floor(max));}
function printCSS(css){var json={url:document.URL,template:window.ezoTemplate,formfactor:window.ezoFormfactor,domainid:window._ezaq.domain_id,css:[]};var UA=navigator.userAgent;if(UA.includes("ezocss")){for(var href in css){var parsedCSS=parse(css[href],null);var parsedCSSString=stringify(parsedCSS);var matchedCSS=surgeon.getUsedCSSForOrigStyleSheet(parsedCSS);json.css.push({url:href,css:matchedCSS,origcss:parsedCSSString});}
var xhr=new XMLHttpRequest();xhr.open("POST","/cheetah/OrigCSS.go",true);xhr.setRequestHeader('Content-Type','application/json');xhr.send(JSON.stringify(json));}else{var timeout=getRandomInt(10);setTimeout(()=>{for(var href in css){var parsedCSS=parse(css[href],null);var parsedCSSString=stringify(parsedCSS);var matchedCSS=surgeon.getUsedCSSForOrigStyleSheet(parsedCSS);json.css.push({url:href,css:matchedCSS,origcss:parsedCSSString});}
var xhr=new XMLHttpRequest();xhr.open("POST","/cheetah/OrigCSS.go",true);xhr.setRequestHeader('Content-Type','application/json');xhr.send(JSON.stringify(json));},timeout*1000);}}
function runsurgeon(){var sheets=document.styleSheets;var hrefs=[];for(var i in sheets){if(sheets[i].href!==null&&sheets[i].href!==undefined&&sheets[i].href!=""&&sheets[i].href.includes(window.ezdomain)){try{hrefs.push(sheets[i].href);}catch(e){}}}
eachAsync(hrefs,loadFile,printCSS);}
var UA=navigator.userAgent;if(UA.includes("ezocss")){setTimeout(runsurgeon,3000);}else{setTimeout(runsurgeon,(getRandomInt(15)+5)*1000);}