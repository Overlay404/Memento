Министерство цифрового развития государственного управления,
информационных технологий и связи Республики Татарстан
государственное автономное профессиональное учреждение
 «Международный центр компетенций –
Казанский техникум информационных технологий и связи»



КУРСОВОЙ ПРОЕКТ
ПО ДИСЦИПЛИНЕ ПМ 05 МДК 05.01 «ПРОЕКТИРОВАНИЕ И ДИЗАЙН ИНФОРМАЦИОННЫХ СИСТЕМ»
ПО ТЕМЕ: «СЕТЬ КОСМЕТИЧЕСКИХ МАГАЗИНОВ»



Исполнитель,
студент группы: 323 СИС            __________________   А.Д. Алексеев
                            подпись, дата

Руководитель                             __________________   Н.А. Плаксин
                              подпись, дата



Казань, 2023 г. 
СОДЕРЖАНИЕ

1 Описание предметной области	4
2 Средства разработки	5
3 Описание процессов	8
4 Проектирование и разработка	10
5 Потенциал	12
7 Приложение А	14
8 Приложение В	15


 
ВВЕДЕНИЕ
В современном мире информационные системы являются неотъемлемой частью жизни каждого человека, а также организаций, предприятий и государственных учреждений. Информационные системы помогают упростить и оптимизировать процессы обработки информации, увеличить эффективность работы и сократить временные затраты. 
Проектирование и дизайн информационных систем – это важный этап в создании нового продукта, который зависит от определенных технологических требований и потребностей пользователей. На этапе разработки необходимо учитывать специфику бизнес-процессов, функциональные требования заказчика, а также особенности доступа и использования пользователей. 
В данной курсовой работе будет рассмотрена тема проектирования и дизайна информационных систем. В ходе работы будут выявлены основные подходы к созданию информационных систем, рассмотрены особенности их функционирования, проанализированы примеры успешной реализации проектов. Также будет дана оценка влияния проектирования и дизайна на эффективность работы информационных систем в целом.  
1 Описание предметной области
Приложение, которое предоставляет удобный интерфейс для управления учебным процессом, включая возможность создания расписания занятий, назначения заданий и учёта посещаемости студентов, может иметь следующие функциональные возможности: 
	Создание расписания занятий: приложение должно позволять преподавателям создавать расписание занятий в удобном графическом интерфейсе. Расписание должно быть видно на всех устройствах и всегда должно быть свежим и актуальным. 
	Назначение заданий: приложение должно позволять преподавателям быстро и удобно назначать задания студентам для выполнения во время занятий или вне класса. Оно также должно предоставлять возможность выставлять оценки и оставлять комментарии к работам. 
	Мониторинг посещаемости: приложение должно позволять преподавателям отмечать посещаемость студентов и получать статистику по посещаемости за определенный период времени. Оно также должно предоставлять возможность отмечать задержания, пропуски и т.д. 
	Быстрый доступ к информации: приложение должно обеспечивать быстрый и удобный доступ к информации о студентах, их успехах и достижениях. Статистика по успеваемости студентов также должна быть доступна для преподавателей. 
	Анализ и отчёты: приложение должно иметь возможность анализировать информацию о посещаемости и успеваемости студентов и предоставлять статистику в виде графиков и отчётов, которые могут быть использованы для принятия решений по улучшению учебного процесса.
В целом, приложение должно предоставлять удобный интерфейс для управления учебным процессом, включая создание расписания занятий, назначение заданий и учёт посещаемости. Оно должно быть доступно для использования на всех типах устройств и поддерживать безопасность и конфиденциальность данных студентов.
2 Средства разработки
Выбранный язык программирования -  C# на платформе .NET Framework. 
.NET Framework представляет собой набор программ, позволяющих разрабатывать приложения. Ее версии постоянно усовершенствовались, модернизировались, встраивались новые инструменты и функции. На сегодня этот комплекс пользуется большой популярностью среди программистов, поскольку равных ему практически нет.
Используя платформу .NET Framework, можно разрабатывать любые приложения, поскольку она обеспечивает совместимость разных служб, написанных на разных языках и способна устранить возможные конфликты между разными версиями.
Достоинства .NET Framework:
1.	объектно-ориентированная модель разработки ПО;
2.	простая и действенная система кэширования;
3.	Visual Studio, интегрированная среда, позволяющая разрабатывать, тестировать и опубликовывать приложения на нескольких платформах;
4.	кроссплатформенность, способность, позволяющая работать с разными платформами
5.	автомониторинг;
6.	библиотека;
7.	большое количество пользователей;
8.	несложное обслуживание.
Для создание программного продукта была выбрана Visual Studio. Интегрированная среда разработки (IDE) — это многофункциональная программа, которая поддерживает многие аспекты разработки программного обеспечения. Интегрированная среда разработки Visual Studio — это стартовая площадка для написания, отладки и сборки кода, а также последующей публикации приложений. 
Помимо стандартного редактора и отладчика, которые есть в большинстве сред IDE, Visual Studio включает в себя компиляторы, средства автозавершения кода, графические конструкторы и многие другие функции для улучшения процесса разработки.
Вот несколько популярных возможностей Visual Studio, которые повышают производительность при разработке программного обеспечения:
1.	Волнистые линии и быстрые действия.
Волнистые линии обозначают ошибки или потенциальные проблемы кода прямо во время ввода. Эти визуальные подсказки помогают немедленно устранить проблемы, не дожидаясь появления ошибок во время сборки или выполнения. Если навести указатель мыши на волнистую линию, на экран будут выведены дополнительные сведения об ошибке. Также в поле слева может отображаться лампочка, указывающая на наличие сведений о быстрых действиях для устранения ошибки.
2.	Очистка кода.
Вы можете одним нажатием кнопки отформатировать код и применить к нему исправления, предложенные параметрами стиля кода, соглашениями в файле .editorconfig и (или) анализаторами Roslyn. Очистка кода, которая сейчас доступна только для кода C#, помогает устранять проблемы в коде перед переходом к его проверке.
3.	Рефакторинг.
Рефакторинг включает в себя такие операции, как интеллектуальное переименование переменных, извлечение одной или нескольких строк кода в новый метод и изменение порядка параметров методов.
4.	IntelliSense.
IntelliSense — это набор возможностей, отображающих сведения о коде непосредственно в редакторе и в некоторых случаях, автоматически создающих небольшие отрывки кода. По сути, это встроенная в редактор базовая документация, которая избавляет от необходимости искать информацию в других источниках.
5.	Поиск в Visual Studio.
Иногда вам будет казаться, что в Visual Studio слишком много меню, действий и свойств. Чтобы быстро находить функции интегрированной среды разработки или элементы кода, в Visual Studio представлен единый компонент поиска (CTRL+Q).
В качестве системы управления баз данных (СУБД) была выбрана - Microsoft SQL Server.
SQL Server – это программа, которая предназначена для хранения и обработки данных. При взаимодействии с ней пользователи могут отправлять запросы и получать ответы – причем как локально, так и по сети.
Основные достоинства:
1.	Масштабирование системы. Взаимодействовать с ней можно как на простых ноутбуках, так и на ПК с мощным процессором, который способен обрабатывать большой объем запросов.
2.	Размер страниц – до 8 Кб. Данные извлекаются быстро, а сложную информацию удобнее хранить. Система обрабатывает транзакции в интерактивном режиме, есть динамическая блокировка.
3.	Автоматизация рутинных административных задач. Например, управление блокировками и памятью, редактура размеров файлов. В программе продуманы настройки, можно создавать профили пользователей.
4.	Удобный поиск. Его можно осуществлять по фразам, словам, тексту либо создавать ключевые индексы.
5.	Поддержка работы с другими решениями Майкрософт, в том числе с Excel, Access.
Также в программе предусмотрена синхронизация, есть репликации через интернет, службы преобразования информации и полноценный web-ассистент для форматирования страниц. Дополнительно в нее интегрирован сервис интерактивного анализа (можно принимать решения, создавать корпоративные отчеты). 
3 Описание процессов
В нашей информационной системе имеется 1 узел: преподаватель.
Преподаватель, используя свой персональный компьютер, открывая наше приложение имеет возможность:
•	Анализа и создание и просмотра отчётов о студентах, парах, посещаемости, расписанию.
•	Быстрого доступа к информации.
•	Мониторинг посещаемости.
•	Назначение домашних заданий.
•	Записи каких либо комментариев к студенту или паре.
 
Схема взаимодействия между узлами представлена на рисунке 1.
 
Рисунок 1 Схема взаимодействия узлов
  
4 Проектирование и разработка
В ходе проектирования будущего проекта была создана ERD-диаграмма с целью визуального отображения взаимодействия между объектами. Диаграмма представлена на рисунке 2.
 Рисунок 2 ERD-диаграмма
Диаграмма активности UML позволяет более детально визуализировать конкретный случай использования. Это поведенческая диаграмма, которая иллюстрирует поток деятельности через систему. 



Диаграмма активности представлена на рисунке 3.
 Рисунок 3 Диаграмма активностей
Далее была разработана диаграмма базы данных в Microsoft SQL Server Management Studio, представленная на рисунке 4.
 
Рисунок 4 Диаграмма базы данных
После успешного проектирования было разработано несколько приложений, работающих с общей базой данных. Приложения отличатся доступностью изменения данных, функциональностью по ролям: администратор сети, администратор магазина, сотрудник магазина и покупатель.
4.1 Администратор сети
Администратор сети определяет список продуктов, которые могут продаваться во всех магазинах, может снимать их с продажи и тогда они автоматически снимаются с остатков, а доступ у других ролей к этому продукту пропадает. Ранее снятый с продажи продукт можно вернуть в продажу.
 
Рисунок 5 Приложение администратора сети
 
Рисунок 6 Редактирование продукта
Для удобного просмотра продукции имеется сортировка на продукцию, имеющуюся в продаже, не имеющуюся в продаже и все.
 
Рисунок 7 Сортировка 
При добавлении нового продукта автоматически применяется картинка заглушка, тоже самое происходит при удалении имеющегося фото. Добавление нового фото без заполненных данных невозможно.
 
Рисунок 8 Добавление нового продукта
Также администратор сети добавляет новых администраторов и сотрудников в магазины, назначая им логин и пароль для дальнейшего пользования системой.
 
Рисунок 9 Сотрудники

 
Рисунок 10 Информация о сотруднике
Есть возможность добавления новых магазинов.
 
Рисунок 11 Магазины сети
 
Рисунок 12 Добавление магазина

4.2 Администратор магазина
Приложение администратора магазина требует авторизацию для того, чтобы администратор работал исключительно со своим магазином.
 
Рисунок 13 Авторизация администратора
Сотрудники магазина не имеют доступ в данное приложение.
 
Рисунок 14 Уведомление
После авторизации администратор видит наименование и адрес своего магазина, сотрудников и доступную к продаже продукцию. Администратор может редактировать и добавлять только сотрудников магазина.
 
Рисунок 15 Администратор магазина
Администратор сети определяет список продукции, с которой могут работать в дальнейшем его сотрудники. Но он не может вносить новые продукты, только доступные к продаже и ранее внесенные администратором сети. При редактировании имеется возможность изменения актуального количества товара, если сотрудник при введении данных совершил ошибку.
 
Рисунок 16 Продукция магазина
 
Рисунок 17 Изменение количества
 
Рисунок 18 Добавление продукта в магазин
 
Рисунок 19 Выбор существующего продукта
4.3 Сотрудник магазина
Сотрудник магазина видит минимальную информацию о продукте. Имеет возможность поиска по коду товара и добавление товара в наличие при его поступлении. Он не может удалять или обновлять информацию.
 
Рисунок 20 Приложение сотрудника
 
Рисунок 21 Добавление продукции
4.4 Покупатель
Покупатель видит уже конечную информацию о наличии товара. До выбора конкретного магазина он видит список товаров, которые вовсе могут продаваться в сети магазинов. После выбора магазина информация сменяется товарами конкретного магазина и информации о его количестве в наличии. Об этом покупатель получает соответствующее уведомление.
 
Рисунок 22 Уведомление
 
Рисунок 23 Ассортимент сети


 
Рисунок 24 Ассортимент магазина 
5 Заключение
До разработки АИС администратор сети магазинов документально оформлял введение нового товара в продажу, с указанием всей необходимой информации, и отправлял эти документы каждому локальному администратору магазина с целью ознакомления и дальнейшей передачи сотрудникам.
Локальный администратор передавал эти данные своим сотрудникам, сообщал о необходимости произведения приема поставки новых товаров и актуализации наличия товаров. 
Полученную информацию о наличии каждого товара сотрудник оформлял документально и передавал руководству лично. Это занимало много рабочего времени из-за чего происходила нехватка сотрудников в торговом зале и на кассах. Клиенты не могли получить консультацию по своим вопросам.
Также посетители не могли получить информацию об актуальном наличии товаров в нужном им магазине сети, из-за чего происходил длительный по времени поиск товара среди всех магазинов сети, что является крайне неудобным для клиента. По этой причине был отток посещаемости магазинов, так как клиент выбирал для себя магазины других сетей.
После внедрения АИС рабочий процесс был значительно ускорен: администратор сети вносит в систему новый товар к продаже, после чего сотрудники могут вносить его в наличие; при списании товара с продажи он автоматически пропадает из системы сотрудников и клиентов.
Внесение сотрудниками актуальной информации о наличии производится в системе, где реализована также возможность поиска товара по коду. Сотрудники больше не обременены излишней бумажной работой и повышают эффективность своей работы.


Посещаемость магазинов значительно повысилась, так как клиент, может не выходя из дома получить информацию о том, какие товары и в каком магазине имеются в наличии, а также их количество. Клиенты могут выбирать для просмотра товаров любой удобный магазин сети.

 
6 Список использованных источников
1.	Интернет-ресурс «Шпаргалка по программированию» - https://www.turboreferat.ru/programming-computer/shpargalka-po-programmirovaniju/27151-131838-page1.html
2.	Интернет-ресурс «Автоматизированные информационные системы: понятие, классификация, назначение» - https://infopedia.su/18xd5f6.html
3.	Интернет-ресурс «Поделись» - http://lib3.podelise.ru/docs/867/index-32045-2.html
4.	Интернет-ресурс «Си Шарп: описание и особенности языка» - https://otus.ru/journal/si-sharp-opisanie-i-osobennosti-yazyka/ 
5.	Интернет-ресурс «Microsoft SQL Server 2014» - https://www.allware.ru/microsoft-sql-server-127 
6.	Интернет-ресурс «Диаграмма вариантов использования» - https://flexberry.github.io/ru/fd_use-case-diagram.html2
7.	Интернет-ресурс «Что такое ER-диаграмма и как ее создать?» - https://www.lucidchart.com/pages/ru/erd 
8.	Интернет-ресурс «Диаграмма деятельности» - https://ru.wikipedia.org/wiki 
9.	Интернет-ресурс «Связи между таблицами базы данных» - https://habr.com/ru/articles/488054/
10.	Интернет-ресурс «Что такое Visual Studio?» - https://learn.microsoft.com/ru-ru/visualstudio/get-started/visual-studio-ide?view=vs-2022  
7 Приложение А

 
8 Приложение В
   public partial class AddEditEmployeePage : Page
    {
       public Employee Employee;
        public AddEditEmployeePage(Employee employees)
        {
            InitializeComponent();
            CbShopAdress.ItemsSource = WpfApp1.DBConnect.ConnectClass.db.Shop.ToList();
            CbShopAdress.DisplayMemberPath = "shopsAdress";
            CbCategory.ItemsSource = WpfApp1.DBConnect.ConnectClass.db.Category.ToList();
            CbCategory.DisplayMemberPath = "Name";
            Employee = employees;
            DataContext = Employee;
            Up();
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WpfApp1.MyPages.EmployeePage());
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if(Employee == null)
            {
                Employee Employee1 = new Employee();
                Employee1.Name = TbName.Text.Trim();
                Employee1.FName = TbFName.Text.Trim();
                Employee1.LName = TbLName.Text.Trim();
                Employee1.Login = TbLog.Text.Trim();
                Employee1.Password = TbPass.Text.Trim();
                Category category = (Category)CbCategory.SelectedItem;
                Employee1.CategoryID = category.id;
                Shop shop = (Shop)CbShopAdress.SelectedItem;
                Employee1.ShopID = shop.id;
                DBConnect.ConnectClass.db.Employee.Add(Employee1); 
            }
              DBConnect.ConnectClass.db.SaveChanges();
            MessageBox.Show("Сделано", "Оповещение");
            NavigationService.Navigate(new WpfApp1.MyPages.EmployeePage());
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WpfApp1.MyPages.EmployeePage());
        }
        public void Up()
        {
            bool b = true;
            if( TbLName.Text.Trim().Length < 1)
            {
                b = false;
            }
            if (TbFName.Text.Trim().Length < 1)
            {
                b = false;
            }
            if(TbName.Text.Trim().Length < 1)
            {
                b = false;
            }
            if (TbLog.Text.Trim().Length < 1)
            {
                b = false;
            }
            if(TbPass.Text.Trim().Length < 1)
            {
                b = false;
            }

            if(CbCategory.SelectedIndex < 0 || CbShopAdress.SelectedIndex < 0)
            {
                b = false;
            } 
            BtnSave.IsEnabled = b; 
        }
       private void TbFName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Up();
        }
 private void CbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Up();
        }
    }
}
   public partial class Employee
    {
        public string FIO
        {
            get
            {
                return FName + " " + Name + " " + LName;
            }
        }

        public string Shops
        {
            get
            {
                return "Магазин " + Shop.Name + " г." + Shop.City.Name + " ул. " + Shop.Street.Name + " д. " + Shop.HouseNumber;
            }
        }
    }
   public partial class Shop
    {

        public string shopsAdress
        {
            get
            {
                return Name + " г. " + City.Name + " ул. " + Street.Name + " д. " + HouseNumber;
            }
        }
    }
  public partial class AddProductPage : Page
    {
        DBConnect.Product Prod;
        public AddProductPage()
        {
            InitializeComponent();
            List<ProductInShop> productIns = DBConnect.ConnectClass.db.ProductInShop.Where(x => x.ShopID == Classes.AuthAdmin.AuthEmpl.ShopID).ToList();
            List<DBConnect.Product> products = DBConnect.ConnectClass.db.Product.Where(x => x.IsDelete != false).ToList();
            List<DBConnect.Product> products2 = new List<Product>();



            for (int i = 0; i < products.Count; i++)
            {
                int id = products[i].id;
                ProductInShop inShop = DBConnect.ConnectClass.db.ProductInShop.Where(x => x.ProductID == id).FirstOrDefault();
                if (inShop != null)
                {
                    if (inShop.IsDelete != true)
                    {
                        products2.Add(products[i]);

                    }
                }
                else
                {
                    products2.Add(products[i]);
                }

            }
            CbProduct.ItemsSource = products2;
            CbProduct.DisplayMemberPath = "Name";

        }

        private void CbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DBConnect.Product product = (DBConnect.Product)CbProduct.SelectedItem;
            DataContext = product;
            Prod = product;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            ProductInShop inShop = DBConnect.ConnectClass.db.ProductInShop.Where(x => x.ProductID == Prod.id && x.ShopID == Classes.AuthAdmin.AuthEmpl.ShopID).FirstOrDefault();
            if (inShop == null)
            {
                ProductInShop inShop2 = new ProductInShop();
                inShop2.ShopID = Classes.AuthAdmin.AuthEmpl.ShopID;
                inShop2.ProductID = Prod.id;
                inShop2.Count = 0;
                inShop2.IsDelete = true;
                DBConnect.ConnectClass.db.ProductInShop.Add(inShop2);
                DBConnect.ConnectClass.db.SaveChanges();

            }
            else
            {
                inShop.Count = 0;
                inShop.IsDelete = true;
            }

            DBConnect.ConnectClass.db.SaveChanges();
            MessageBox.Show("Сохранено, товар появится в продаже в вашем магазине с актульным количеством в наличии - 0", "Уведомление");
            NavigationService.Navigate(new MyPages.ProductPage());

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyPages.ProductPage());
        }
    }
   public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBConnect.Employee empl= DBConnect.ConnectClass.db.Employee.Where(x => x.Login == TbLogin.Text && x.Password == TbPass.Text).FirstOrDefault();
            if( empl == null)
            {
                MessageBox.Show("Данные введены неверно","Уведомление");
                TbLogin.Text = null;
                TbPass.Text = null;
            }
            else
            {
                if(empl.CategoryID == 1)
                {
                    WpfApp2.Classes.AuthAdmin.AuthEmpl = empl;
                    NavigationService.Navigate(new WpfApp2.MyPages.PageOsn());
                }
                else
                {
                    MessageBox.Show("У вас недостаточно прав для авторизации в этом приложении", "Уведомление");
                    TbLogin.Text = null;
                    TbPass.Text = null;
                }
            }
        }
    }
  public partial class AddProductPage : Page
    {
        DBConnect.ProductInShop inShop;
        public AddProductPage(DBConnect.ProductInShop sel)
        {
            InitializeComponent();
            DataContext = sel;
            inShop = sel;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(TbProductCont.Text.Length > 0)
            {
                inShop.Count = inShop.Count + int.Parse(TbProductCont.Text);
                DBConnect.ConnectClass.db.SaveChanges();
                MessageBox.Show("Количество товаров было обновлено","Уведомление");
                NavigationService.Navigate(new WpfApp3.MyPages.OsnPage());
            }
        }
private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WpfApp3.MyPages.OsnPage());
        }
private void TbProductCont_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = TbProductCont.Text;
            string text2 = "";
            foreach (char a in text)
            {
                if (a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9' || a == '0')
                {
                    text2 = text2 + a;
                }
            }
            TbProductCont.Text = text2;
        }
    }
public partial class OsnPage : Page
    {
        public OsnPage()
        {
            InitializeComponent();
            Up();
        }

        void Up()
        {
            List<DBConnect.ProductInShop> productInShops = DBConnect.ConnectClass.db.ProductInShop.Where(x => x.ShopID == Classes.AuthEmpl.AuthEmpls.ShopID && x.Product.IsDelete != false && x.IsDelete != false).ToList();
            if (TbSearch.Text.Length > 0)
            {
                productInShops = productInShops.Where(x => x.Product.id.ToString().StartsWith(TbSearch.Text.ToString())).ToList();

            }


            ListProduct.ItemsSource = productInShops;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            DBConnect.ProductInShop sel = (sender as Button).DataContext as DBConnect.ProductInShop;

            NavigationService.Navigate(new MyPages.AddProductPage(sel));
        }

        private void TnSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            string text = TbSearch.Text;
            string text2 = "";
            foreach (char a in text)
            {
                if (a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9' || a == '0')
                {
                    text2 = text2 + a;
                }

            }
            TbSearch.Text = text2;

            Up();
        }
    }
  public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrames.Visibility = Visibility.Visible;
            LVProduct.Visibility = Visibility.Collapsed;

            MyFrames.Navigate(new WpfApp4_Kyrs.Pages.ListPages(null));


            CbShop.ItemsSource = DBConnect.ConnectClass.db.Shop.ToList();
            CbShop.DisplayMemberPath = "shopsAdress";
            MessageBox.Show("До выбора конкретного магазина у вас будет показываться весь список товаров, доступный в нашей сети. Всего хорошего!", "Уведомление", MessageBoxButton.OK);
        }
        void Up()
        {
            List<DBConnect.ProductInShop> products = DBConnect.ConnectClass.db.ProductInShop.Where(x => x.IsDelete != false).ToList();
            if (CbShop.SelectedIndex != -1)
            {
                DBConnect.Shop shop = (DBConnect.Shop)CbShop.SelectedItem;
                products = products.Where(x => x.ShopID == shop.id).ToList();

            }
            if (TbSearch.Text.Length > -1 && CbShop.SelectedIndex != -1)
            {
                products = products.Where(x => x.Product.Name.ToLower().StartsWith(TbSearch.Text.ToLower())).ToList();
            }
            if (products != null)
                LVProduct.ItemsSource = products;
            else
            {
                MessageBox.Show("nu");
            }
        }
        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TbSearch.Text.Length > 0 && CbShop.SelectedIndex == -1)
            {
                List<DBConnect.Product> products = (DBConnect.ConnectClass.db.Product.Where(x => x.IsDelete != false && x.Name.ToLower().StartsWith(TbSearch.Text.ToLower())).ToList());
                MyFrames.Navigate(new WpfApp4_Kyrs.Pages.ListPages(products));

            }
            else if (TbSearch.Text.Length == 0 && CbShop.SelectedIndex == -1)
            {
                List<DBConnect.Product> products = (DBConnect.ConnectClass.db.Product.Where(x => x.IsDelete != false).ToList());
                MyFrames.Navigate(new WpfApp4_Kyrs.Pages.ListPages(products));
            }
            else
            {
                Up();
            }
        }

        private void CbShop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbShop.SelectedIndex != -1)
            {
                MyFrames.Visibility = Visibility.Collapsed;
                LVProduct.Visibility = Visibility.Visible;
                Up();
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            CbShop.SelectedIndex = -1;
            TbSearch.Text = null;
            MyFrames.Visibility = Visibility.Visible;
            MyFrames.Navigate(new WpfApp4_Kyrs.Pages.ListPages(null));
            LVProduct.Visibility = Visibility.Collapsed;
        }
    }
  public partial class ShopsPage : Page
    {
        public ShopsPage()
        {
            InitializeComponent();
            ListShop.ItemsSource = DBConnect.ConnectClass.db.Shop.Where(x => x.IsDelete != true).ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WpfApp1.MyPages.AddEditShopsPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Shop shopSel = (sender as Button).DataContext as Shop;
            NavigationService.Navigate(new WpfApp1.MyPages.AddEditShopsPage(shopSel));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Вы хотите удалить этот магазин? Все связанные данные также пропадут", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Shop sel = (sender as Button).DataContext as Shop;
                sel.IsDelete = true;
                List<Employee> employees = DBConnect.ConnectClass.db.Employee.Where(x => x.ShopID == sel.id).ToList();
                for (int i = 0; i < employees.Count; i++)
                {
                    employees[i].IsDelete = true;
                }

                List<ProductInShop> productInShops = DBConnect.ConnectClass.db.ProductInShop.Where(x => x.ShopID == sel.id).ToList();
                for (int i = 0; i < productInShops.Count; i++)
                {
                    productInShops[0].IsDelete = true;
                }
                DBConnect.ConnectClass.db.SaveChanges();
                MessageBox.Show("Сделано", "Уведомление");
                ListShop.ItemsSource = DBConnect.ConnectClass.db.Shop.Where(x => x.IsDelete != true).ToList();
            }
        }
    }
}
  public partial class ProductPage : Page
    {
        public static ProductPage Instance;
        List<DBConnect.Product> products1 = new List<Product>();

        public ProductPage(List<DBConnect.Product> products = null)
        {
            InitializeComponent();
            Instance = this;
            //NavigationService.Navigate(new MyPages.ProductPage());
            ListProduct.ItemsSource = products ?? DBConnect.ConnectClass.db.Product.ToList();
            Up();
        }
        public void Up()
        {
            List<Product> products = DBConnect.ConnectClass.db.Product.ToList();
            if (InShopsTrue.IsChecked == true)
            {
                products = products.Where(x => x.IsDelete != false).ToList();
            }
            else if (InShopNotsTrue.IsChecked == true)
            {
                products = products.Where(x => x.IsDelete == false).ToList();
            }
            else if (InShopsTrueAll.IsChecked == true)
            {
                products = DBConnect.ConnectClass.db.Product.ToList();
            }
            products = products.OrderByDescending(x => x.IsDelete).ToList();
            if (ListProduct != null)
                ListProduct.ItemsSource = products;
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WpfApp1.MyPages.ProductAddEditPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            DBConnect.Product sel = (sender as Button).DataContext as DBConnect.Product;
            NavigationService.Navigate(new WpfApp1.MyPages.ProductAddEditPage(sel));
        }
        private void InShopsTrue_Click(object sender, RoutedEventArgs e)
        {
            if (InShopsTrue.IsChecked == true)
            {
                InShopsTrueAll.IsChecked = false;
                InShopNotsTrue.IsChecked = false;
            }
            Up();
        }
        private void InShopsTrueAll_Click(object sender, RoutedEventArgs e)
        {
            if (InShopsTrueAll.IsChecked == true)
            {
                InShopsTrue.IsChecked = false;
                InShopNotsTrue.IsChecked = false;
            }
            Up();
        }
        private void InShopNotsTrue_Click(object sender, RoutedEventArgs e)
        {
            if (InShopNotsTrue.IsChecked == true)
            {
                InShopsTrue.IsChecked = false;
                InShopsTrueAll.IsChecked = false;
            }
            Up();
        }
    }

