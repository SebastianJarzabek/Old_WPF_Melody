namespace Melody.Service.SqlExecuters
{
  public class SqlExecute
  {
    private readonly string _addDestiny = "Exec AddDestiny";

    private readonly string _addEmployee = "Exec AddEmployee ";

    private readonly string _addMaterial = "Exec AddMaterial";

    private readonly string _addOrder = "Exec AddOrder";

    private readonly string _addSupplier = "Exec AddSupplier";

    private readonly string _addUnit = "Exec AddUnit";

    private readonly string _addWarehouseAdmission = "Exec AddWarehouseAdmission";

    private readonly string _addWarehouseIssue = "Exec AddWarehouseIssue";

    private readonly string _deleteDestiny = "Exec DeleteDestiny";

    private readonly string _deleteEmployee = "Exec DeleteEmployee";

    private readonly string _deleteMaterial = "Exec DeleteMaterial";

    private readonly string _deleteOrder = "Exec DeleteOrder";

    private readonly string _deleteSupplier = "Exec DeleteSupplier";

    private readonly string _deleteUnit = "Exec DeleteUnit";

    private readonly string _deleteWarehouseAdmissionFromId = "Exec DeleteWarehouseAdmissionFromId";

    private readonly string _deleteWarehouseIssueFromId = "Exec DeleteWarehouseIssueFromId";

    private readonly string _getAllOrder = "Exec GetAllOrder";

    private readonly string _getAllWarehouseIssue = "Exec GetAllWarehouseIssue";

    private readonly string _getAllWarehouseIssueFromId = "Exec GetAllWarehouseIssueFromId";

    private readonly string _getDestiny = "Exec GetDestiny";

    private readonly string _getDestinyFromId = "Exec GetDestinyFromId";

    private readonly string _getEmployee = "Exec GetEmployee";

    private readonly string _getMaterialFromId = "Exec GetMaterialFromId";

    private readonly string _getOrderFromId = "Exec GetOrderFromId";

    private readonly string _getSupplierFromId = "Exec GetSupplierFromId";

    private readonly string _getUnitFromId = "Exec GetUnitFromId";

    private readonly string _updateDestiny = "Exec UpdateDestiny";

    private readonly string _updateEmployee = "Exec UpdateEmployee";

    private readonly string _updateMaterial = "Exec UpdateMaterial";

    private readonly string _updateOrder = "Exec UpdateOrder";

    private readonly string _updateQuantityInventoryLevel = "Exec UpdateQuantityInventoryLevel";

    private readonly string _updateSupplier = "Exec UpdateSupplier";

    private readonly string _updateUnit = "Exec UpdateUnit";

    private readonly string _updateWarehouseAdmission = "Exec UpdateWarehouseAdmission";

    private readonly string _updateWarehouseIssue = "Exec UpdateWarehouseIssue";

    private readonly string _usersLogin = "Exec UsersLogin";

    public string UsersLogin { get => _usersLogin; }

    public string AddDestiny { get => _addDestiny; }

    public string AddEmployee { get => _addEmployee; }

    public string AddMaterial { get => _addMaterial; }

    public string AddOrder { get => _addOrder; }

    public string AddSupplier { get => _addSupplier; }

    public string AddUnit { get => _addUnit; }

    public string AddWarehouseAdmission { get => _addWarehouseAdmission; }

    public string AddWarehouseIssue { get => _addWarehouseIssue; }

    public string DeleteDestiny { get => _deleteDestiny; }

    public string DeleteEmployee { get => _deleteEmployee; }

    public string DeleteMaterial { get => _deleteMaterial; }

    public string DeleteOrder { get => _deleteOrder; }

    public string DeleteSupplier { get => _deleteSupplier; }

    public string DeleteUnit { get => _deleteUnit; }

    public string DeleteWarehouseAdmissionFromId { get => _deleteWarehouseAdmissionFromId; }

    public string DeleteWarehouseIssueFromId { get => _deleteWarehouseIssueFromId; }

    public string GetAllOrder { get => _getAllOrder; }

    public string GetAllWarehouseIssue { get => _getAllWarehouseIssue; }

    public string GetAllWarehouseIssueFromId { get => _getAllWarehouseIssueFromId; }

    public string GetDestiny { get => _getDestiny; }

    public string GetDestinyFromId { get => _getDestinyFromId; }

    public string GetEmployee { get => _getEmployee; }

    public string GetMaterialFromId { get => _getMaterialFromId; }

    public string GetOrderFromId { get => _getOrderFromId; }

    public string GetSupplierFromId { get => _getSupplierFromId; }

    public string GetUnitFromId { get => _getUnitFromId; }

    public string UpdateDestiny { get => _updateDestiny; }

    public string UpdateEmployee { get => _updateEmployee; }

    public string UpdateMaterial { get => _updateMaterial; }

    public string UpdateOrder { get => _updateOrder; }

    public string UpdateQuantityInventoryLevel { get => _updateQuantityInventoryLevel; }

    public string UpdateSupplier { get => _updateSupplier; }

    public string UpdateUnit { get => _updateUnit; }

    public string UpdateWarehouseAdmission { get => _updateWarehouseAdmission; }

    public string UpdateWarehouseIssue { get => _updateWarehouseIssue; }
  }
}