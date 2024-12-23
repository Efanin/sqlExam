using System.Net.Mail;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        int count = 0;
        string Answers = "";
        List<string> quest = new() {
        "Задание #1\r\nВопрос:\r\nПервичный ключ в реляционной базе данных служит для:\r\nВыберите один из 4 вариантов ответа:\r\n1) указания типа поля\r\n2) связи между различными таблицами в  реляционной базе данных\r\n3) однозначного выделения записи в базе данных\r\n4) организации новой структуры данных\r\n",
        "Задание #2\r\nВопрос:\r\nПолем реляционной БД является:\r\nВыберите один из 4 вариантов ответа:\r\n1) ячейка\r\n2) запись таблицы\r\n3) строка таблицы\r\n4) столбец таблицы\r\n",
        "Задание #3\r\nВопрос:\r\nВыберите правильный SQL запрос для вставки новой записи в таблицу \"Persons\", причём в поле \"LastName\" вставить значение \"Olsen\".\r\nВыберите один из 4 вариантов ответа:\r\n1) INSERT INTO Persons ('Olsen') INTO LastName\r\n2) INSERT INTO Persons ('Olsen') VALUES LastName\r\n3) INSERT INTO Persons (LastName) VALUES ('Olsen')\r\n4) INSERT ('Olsen') INTO Persons (LastName)\r\n",
        "Задание #4\r\nВопрос:\r\nКак изменить значение \"Hansen\" на \"Nilsen\" в колонке \"LastName\", таблицы Persons?\r\nВыберите один из 4 вариантов ответа:\r\n1) MODIFY Persons SET LastName='Nilsen' WHERE LastName='Hansen'\r\n2) MODIFY Persons SET LastName='Hansen' INTO LastName='Nilsen\r\n3) UPDATE Persons SET LastName='Nilsen' HAVING LastName='Hansen'\r\n4) UPDATE Persons SET LastName='Nilsen' WHERE LastName='Hansen'\r\n",
        "Задание #5\r\nВопрос:\r\nКак выбрать все записи из таблицы \"Persons\", упорядоченных по полю \"FirstName\" в обратном порядке?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT * FROM Persons ORDER BY FirstName ASC\r\n2) SELECT * FROM Persons SORT BY 'FirstName' ACS\r\n3) SELECT * FROM Persons ORDER 'FirstName' DESC\r\n4) SELECT * FROM Persons ORDER BY FirstName DESC\r\n",
        "Задание #6\r\nВопрос:\r\nКак удалить записи, где значение поля \"FirstName\" равно \"Peter\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) DELETE FROM FirstName='Peter' FROM Persons\r\n2) DELETE FROM Persons WHERE FirstName = 'Peter'\r\n3) DELETE FROM Persons WHILE FirstName = 'Peter'\r\n4) DELETE FirstName='Peter' FROM Persons\r\n",
        "Задание #7\r\nВопрос:\r\nКоманда SQL предназначенная для выборки данных из базы?\r\nВыберите один из 4 вариантов ответа:\r\n1) EXTRACT\r\n2) CREATE\r\n3) OPEN\r\n4)  SELECT\r\n",
        "Задание #8\r\nВопрос:\r\nЗаписью реляционной базы данных является:\r\nВыберите один из 4 вариантов ответа:\r\n1) столбец таблицы\r\n2) поле таблицы\r\n3) строка таблицы\r\n4) ячейка таблицы\r\n",
        "Задание #9\r\nВопрос:\r\nКоманда, выдающая в результате разность двух запросов\r\n(составить слово)\r\nСоставьте слово из букв:\r\nXCPETE -> __________________________________________\r\n",
        "Задание #10\r\nВопрос:\r\nКак выбрать все записи из таблицы \"Persons\", где значение поля \"FirstName\" равно \"Peter\" и \"LastName\" равно \"Jackson\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT * FROM Persons WHILE FirstName='Peter' AND LastName='Jackson'\r\n2) SELECT  FROM Persons WHERE FirstName like 'Peter' AND LastName like 'Jackson'\r\n3) SELECT * FROM Persons WHERE FirstName<>'Peter' AND LastName<>'Jackson'\r\n4) SELECT * FROM Persons WHERE FirstName='Peter' AND LastName='Jackson'\r\n",
        "Задание #11\r\nВопрос:\r\nПредикат AVG  выводит\r\nВыберите один из 4 вариантов ответа:\r\n1) среднее арифметическое значение\r\n2) выводит истину, если выполняется хотя бы одно условие из списка предложенных\r\n3) задает множество элементов\r\n4) максимальное значение\r\n",
        "Задание #12\r\nВопрос:\r\nКак выбрать все записи из таблицы \"Persons\", где значение поля \"FirstName\" равно \"Peter\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT * FROM Persons WHERE FirstName='Peter'\r\n2) SELECT [all] FROM Persons WHERE FirstName LIKE 'Peter'\r\n3) SELECT DISTINCT FROM Persons WHERE FirstName='Peter'\r\n4) SELECT * FROM Persons WHERE FirstName<>'Peter'\r\n",
        "Задание #13\r\nВопрос:\r\nCоотнести назначение слов языка SQL\r\nУкажите соответствие для всех 5 вариантов ответа:\r\n1) Список таблиц или запросов, на основе которых , формируется запрос\r\n2) Условия отбора данных\r\n3) Группировка результатов по указанному полю\r\n4)  Условия для группировки данных в запросе\r\n5) Список полей, по которым упорядочивается вывод данных в запросе\r\n__ WHERE\r\n__ FROM\r\n__ GROUP BY\r\n__ ORDER BY\r\n__ HAVING\r\n",
        "Задание #14\r\nВопрос:\r\nКак выбрать все записи из таблицы \"Persons\", где значение поля \"FirstName\" начинается с буквы \"a\"?\r\nВыберите один из 4 вариантов ответа:\r\n1)  SELECT * FROM Persons WHERE FirstName='a%'\r\n2) SELECT * FROM Persons WHERE FirstName='*a*'\r\n3) SELECT * FROM Persons WHERE FirstName <> 'a*'\r\n4) SELECT * FROM Persons WHERE FirstName LIKE 'a'\r\n",
        "Задание #15\r\nВопрос:\r\nПоле в СУБД Access, имеющее свойство автоматического наращивания, на единицу\r\nВыберите один из 4 вариантов ответа:\r\n1) Счетчик\r\n2) Числовое\r\n3) Ключевое\r\n4) Текстовое\r\n",
        "Задание #16\r\nВопрос:\r\nКакое SQL выражение используется для извлечения различных значений?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT DISTINCT\r\n2) SELECT INDEX\r\n3) SELECT DIFFERENT\r\n4) SELECT UNIQUE\r\n",
        "Задание #17\r\nВопрос:\r\nКоманда SQL для выборки всех полей из таблицы \"Persons\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT *.Persons\r\n2) SELECT Persons\r\n3) SELECT Any FROM Persons\r\n4) SELECT * FROM Persons\r\n",
        "Задание #18\r\nВопрос:\r\nКак выбрать все записи из таблицы \"Persons\", где значение поля \"LastName\" в алфавитном порядке находится между значениями \"Hansen\" и \"Pettersen\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT * FROM Persons WHERE LastName BETWEEN 'Hansen' AND 'Pettersen'\r\n2) SELECT * FROM Persons WHERE LastName>'Hansen' AND LastName<'Pettersen'\r\n3) SELECT * FROM Persons LastName>='Hansen' AND LastName<='Pettersen'\r\n4) SELECT * FROM Persons WHERE LastName ASC 'Hansen' AND 'Pettersen'\r\n",
        "Задание #19\r\nВопрос:\r\nКакой тип связи между таблицами одной базы данных образуется, когда объединяем два поля с первичными ключами\r\nВыберите один из 4 вариантов ответа:\r\n1) многие ко многим\r\n2) один ко многим\r\n3) Индекс\r\n4) один к одному\r\n",
        "Задание #20\r\nВопрос:\r\nБаза данных состоящая из двумерных таблиц называется...  \r\n(составить слово)\r\nСоставьте слово из букв:\r\nРОНЯЯЦНЛИАЕ -> __________________________________________\r\n",
        "Задание #21\r\nВопрос:\r\nСоотнести операции с таблицей\r\nУкажите соответствие для всех 3 вариантов ответа:\r\n1) создать таблицу\r\n2) изменить таблицу\r\n3) удалить таблицу\r\n__ CREATE TABLE\r\n__ ALTER TABLE\r\n__ DROP TABLE\r\nЗадание #21\r\nВопрос:\r\nСоотнести операции с таблицей\r\nУкажите соответствие для всех 3 вариантов ответа:\r\n1) создать таблицу\r\n2) изменить таблицу\r\n3) удалить таблицу\r\n__ CREATE TABLE\r\n__ ALTER TABLE\r\n__ DROP TABLE\r\n",
        "Задание #22\r\nВопрос:\r\nВыберите правильный SQL запрос для вставки новой записи в таблицу \"Persons\".\r\nВыберите один из 4 вариантов ответа:\r\n1) INSERT INTO Persons (name, lasname) VALUES ('Jimmy', 'Jackson')\r\n2) INSERT ('Jimmy', 'Jackson') INTO Persons\r\n3) INSERT VALUES ('Jimmy', 'Jackson') INTO Persons\r\n4) INSERT INTO Persons VALUES ('Jimmy', 'Jackson')\r\n",
        "Задание #23\r\nВопрос:\r\nСоответствие  назначение объектов в СУБД Access\r\nУкажите соответствие для всех 6 вариантов ответа:\r\n1) Основной объект БД где хранятся данные\r\n2) Объект предназначенный для обработки информации\r\n3) Ввод новых данных или просмотр имеющихся\r\n4) Выдача информации на принтнр в удобном и наглядном виде\r\n5) С помощью макрокоманд автоматизируется процесс работы с БД\r\n6) Программные процедуры написанные на языке Visual Basic (VB)\r\n__ Запросы\r\n__ Макросы\r\n__ Отчеты\r\n__ Модули\r\n__ Таблицы\r\n__ Формы\r\n",
        "Задание #24\r\nВопрос:\r\nТип поля в СУБД Acces, в котором можно хранить рисунки, клипы и другие мультимедийные объекты\r\nВыберите один из 4 вариантов ответа:\r\n1) МЕМО\r\n2) Денежное\r\n3) Логическое\r\n4) OLE\r\n",
        "Задание #25\r\nВопрос:\r\nКакой тип связи между таблицами одной базы данных образуется, когда объединяем поле с первичным ключом с полем без ключа\r\nВыберите один из 3 вариантов ответа:\r\n1) Один к одному\r\n2) Один ко многим\r\n3) Многие ко многим\r\n",
        "Задание #26\r\nВопрос:\r\nКак расшифровывается SQL?\r\nВыберите один из 4 вариантов ответа:\r\n1) Структурированный язык вопросов\r\n2) Система логических вопросов\r\n3) Системно-ключевой локал\r\n4) Структурированный язык запросов\r\n",
        "Задание #27\r\nВопрос:\r\nИспользуя язык SQL выбрать колонку в БД с названием \"FirstName\" из таблицы \"Persons\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) CREATE FirstName ON Persons\r\n2) SELECT Persons.FirstName\r\n3) SELECT FirstName FROM Persons\r\n4) EXTRACT FirstName FROM Persons\r\n",
        "Задание #28\r\nВопрос:\r\nКак вывести количество записей, хранящихся в таблице \"Persons\"?\r\nВыберите один из 4 вариантов ответа:\r\n1) SELECT COLUMNS() FROM Persons\r\n2) SELECT COUNT() FROM Persons\r\n3) SELECT COUNT(*) FROM Persons\r\n4) SELECT COUNT(Persons)\r\n",
        "Задание #29\r\nВопрос:\r\nSQL команда для упорядочивания результатов?\r\nВыберите один из 4 вариантов ответа:\r\n1) ORDER\r\n2) ORDER BY\r\n3) SORT\r\n4) SORT BY\r\n",
        "Задание #30\r\nВопрос:\r\nСоотнести\r\nУкажите соответствие для всех 4 вариантов ответа:\r\n1) отменить изменения\r\n2) удалить строки в таблице\r\n3) добавить строки в таблицу\r\n4) изменить значения\r\n__ INSERT\r\n__ DELETE\r\n__ UPDATE\r\n__ ROLLBACK\r\n"

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = quest[count];
            count++;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (count < quest.Count)
            {
                Answers += textBox1.Text+ "\r\n";
                textBox1.Text = "";
                label1.Text = quest[count];
                count++;
            }
            else
            {
                button1.Text = "complete!";
                label1.Text = "Responses have been sent";
                Answers += textBox2.Text;
                sendMessage();
            }

        }
        private void sendMessage()
        {
            string from = "efanin.igor@gmail.com";
            MailMessage message = new MailMessage(from, from);
            message.Subject = "Answers";
            message.Body = Answers;
            SmtpClient client = new SmtpClient("smtp.google.com", 587);
            client.UseDefaultCredentials = true;
            try
            {
                client.Send(message);
            }
            catch (Exception ex) { }
        }
    }
}
