Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc

Public Class DashboardConfig
    Public Shared Sub RegisterService(routes As RouteCollection)
        routes.MapDashboardRoute()

        ' Uncomment this line to save dashboards to the App_Data folder.
        DashboardConfigurator.Default.SetDashboardStorage(New DashboardFileStorage("~/App_Data/"))

        ' Uncomment these lines to create an in-memory storage of dashboard data sources. Use the DataSourceInMemoryStorage.RegisterDataSource
        ' method to register the existing data source in the created storage.
        Dim dataSourceStorage = New DataSourceInMemoryStorage()
        DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)
    End Sub
End Class