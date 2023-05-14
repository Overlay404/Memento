using System.Data.Entity;

namespace Memento.Model
{
    class Connection
    {
        #region Connection DB
        public static memento_proEntities db { get; set; } = new memento_proEntities();

        /// <summary>
        /// Инициализация конструктора для подключения к бд
        /// </summary>
        public static void ConnectionDb()
        {
            db.User.Load();
            db.Visitor.Load();
            db.VisitPurpose.Load();
            db.Request.Load();
            db.Employee.Load();
            db.Division.Load();
            db.RequestStatus.Load();
            db.RequestType.Load();
            db.RequestRejectionReason.Load();
            db.Organization.Load();
        }
        #endregion
    }
}
