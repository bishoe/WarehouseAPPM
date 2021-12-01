 

SELECT        Warehouse_Store.StoreId, Warehouse_Master_Store.EmployeeId, Warehouse_Store.SupplyRepId, Warehouse_Store.SuppliersId, Warehouse_Master_Store.WDate,
Warehouse_Store.Billno,
Warehouse_Store.PurchasingPrice,
Warehouse_Store.SellingPrice,
Warehouse_Store.ProdouctsID,
Warehouse_Store.[ExpireDate], 
Warehouse_Store.Productiondate,
Warehouse_Store.MainUnitesId,
Warehouse_Store.SUBUnitesId,
 Warehouse_Store.MinimumQT,
Warehouse_Store.SizeProducts,
Warehouse_Store.Notes,
Warehouse_Master_Store.UsersID,       
Warehouse_SupplyRepresentative.SupplyRepID,
Warehouse_SupplyRepresentative.SuppliersID,
Warehouse_SupplyRepresentative.SRName
,Warehouse_Suppliers.SuppliersID, Warehouse_Suppliers.SName,
WatehouseProdoucts.ProdouctsID,
WatehouseProdoucts.Pname
from 
Warehouse_Store
inner join Warehouse_Master_Store on
Warehouse_Master_Store.StoreId=Warehouse_Store.MStoreId 
inner join WatehouseProdoucts
on
Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID
inner join 
Warehouse_Suppliers on
Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID
inner join 

Warehouse_SupplyRepresentative
on
Warehouse_Store.SupplyRepId =Warehouse_SupplyRepresentative.SupplyRepID
--inner join 
--Warehouse_Employee on 
--Warehouse_Master_Store.EmployeeId=
--Warehouse_Employee.EmployeeId 
where Warehouse_Store.Billno =15
--where Warehouse_Master_Store.EmployeeId = Warehouse_Employee.EmployeeId 

--and

--Warehouse_Store.SupplyRepId = Warehouse_SupplyRepresentative.SupplyRepID 

--and
--Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID


--and

--Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID

--and

--Warehouse_Store.Billno =@invoiceNO 
 