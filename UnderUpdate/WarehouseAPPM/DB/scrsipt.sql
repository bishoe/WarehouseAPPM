USE [Warehouse]
GO
SET IDENTITY_INSERT [dbo].[TBROLES] ON 

INSERT [dbo].[TBROLES] ([ROLES_ID], [ROLES_NAME]) VALUES (1, N'Admin')
INSERT [dbo].[TBROLES] ([ROLES_ID], [ROLES_NAME]) VALUES (2, N'Employee')
SET IDENTITY_INSERT [dbo].[TBROLES] OFF
GO
SET IDENTITY_INSERT [dbo].[TBUSERS] ON 

INSERT [dbo].[TBUSERS] ([User_ID], [USER_NAME], [USER_PASSWORD], [USER_LASTLOGIN], [LOCKACCOUNT]) VALUES (1, N'Admin', N'Warehouse@%12', NULL, NULL)
SET IDENTITY_INSERT [dbo].[TBUSERS] OFF
GO
