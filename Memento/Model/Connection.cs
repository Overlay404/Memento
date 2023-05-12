using System.Data.Entity;

namespace Memento.Model
{
    class Connection
    {
        #region Connection DB

        public static prrrEntities Db { get; set; } = new prrrEntities();

        /// <summary>
        /// Инициализация конструктора для подключения к бд
        /// </summary>
        public static void ConnectionDb()
        {
            Db.Pass.Load();
            Db.Employee.Load();
            Db.Docimentation.Load();
            Db.VisitPurpose.Load();
            Db.Subdivision.Load();
            Db.Visitor.Load();
        }
        #endregion
    }
}
