USE [Warehouse]
GO
/****** Object:  View [dbo].[_WarehouseSelectQutalyView]    Script Date: 2/26/2021 2:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[_WarehouseSelectQutalyView]
AS
SELECT        dbo.Warehouse_Qutaly.OutLayUnID, dbo.Warehouse_Qutaly.Amount, dbo.Warehouse_Qutaly.UsersID, dbo.Warehouse_Qutaly.WDate, dbo.Warehouse_Qutaly.Notes, dbo.Warehouse_OutLayUnites.OutLayID, 
                         dbo.Warehouse_OutLayUnites.QName, dbo.Warehouse_Users.UsersID AS Expr1, dbo.Warehouse_Users.U_Username
FROM            dbo.Warehouse_Qutaly INNER JOIN
                         dbo.Warehouse_OutLayUnites ON dbo.Warehouse_Qutaly.OutLayUnID = dbo.Warehouse_OutLayUnites.OutLayID INNER JOIN
                         dbo.Warehouse_Users ON dbo.Warehouse_Qutaly.UsersID = dbo.Warehouse_Users.UsersID






GO
/****** Object:  View [dbo].[_WarehouseSelectUsersView]    Script Date: 2/26/2021 2:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[_WarehouseSelectUsersView]
AS
SELECT        User_ID AS [#], USER_NAME AS الاسم, USER_LASTLOGIN AS [اخر تسجيل دخول]
FROM            dbo.TBUSERS

GO
/****** Object:  View [dbo].[WarehouseSelectAllCustomersARView]    Script Date: 2/26/2021 2:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 

create view [dbo].[WarehouseSelectAllCustomersARView]
WITH SCHEMABINDING 
as
 
 SELECT        CustomersID , CName , Phone , [Address] , WarehouseCustomers. WDate , Notes ,Warehouse_Users.U_Username
FROM         dbo.   WarehouseCustomers,dbo. Warehouse_Users
 









GO
/****** Object:  View [dbo].[WarehouseSelectEmployeeARView]    Script Date: 2/26/2021 2:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






Create view
[dbo].[WarehouseSelectEmployeeARView]
WITH SCHEMABINDING 
as

 
SELECT       dbo. Warehouse_Employee.EmployeeId  ,  dbo. Warehouse_Employee.EName  ,  dbo. Warehouse_Employee.Phone  ,  dbo. Warehouse_Employee.[Address]  ,   dbo. Warehouse_Employee.Salary  ,  dbo. Warehouse_Employee.WDate ,  dbo. Warehouse_Employee.Notes  
FROM           dbo.Warehouse_Employee
  













GO
/****** Object:  View [dbo].[WarehouseSelectProdouctsARView]    Script Date: 2/26/2021 2:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[WarehouseSelectProdouctsARView]
WITH SCHEMABINDING 
as
SELECT        ProdouctsID  , Pname  , WDate  , BarCodeText  
FROM        [dbo].    WatehouseProdoucts







GO
/****** Object:  View [dbo].[WarehouseSelectSuppliersARView]    Script Date: 2/26/2021 2:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[WarehouseSelectSuppliersARView]
WITH SCHEMABINDING 
as
 SELECT        SuppliersID  , SName  , Phone  , [Address]  , Notes  
FROM           dbo. Warehouse_Suppliers







GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBUSERS"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 186
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'_WarehouseSelectUsersView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'_WarehouseSelectUsersView'
GO
