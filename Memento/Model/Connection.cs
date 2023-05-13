using System.Data.Entity;

namespace Memento.Model
{
    class Connection
    {
        #region Connection DB
        public static memento_proEntities Db { get; set; } = new memento_proEntities();

        /// <summary>
        /// Инициализация конструктора для подключения к бд
        /// </summary>
        public static void ConnectionDb()
        {
            Db.User.Load();
            Db.Visitor.Load();
            Db.VisitPurpose.Load();
            Db.Request.Load();
            Db.Employee.Load();
            Db.Division.Load();
            Db.RequestStatus.Load();
            Db.RequestType.Load();
            Db.RequestRejectionReason.Load();
            Db.Organization.Load();
        }
        #endregion
    }
}
