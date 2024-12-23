using System.Net.Mail;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        int count = 0;
        string Answers = "";
        List<string> quest = new() {
        "������� #1\r\n������:\r\n��������� ���� � ����������� ���� ������ ������ ���:\r\n�������� ���� �� 4 ��������� ������:\r\n1)��������� ���� ����\r\n2)������ ����� ���������� ��������� � ������������ ���� ������\r\n3)������������� ��������� ������ � ���� ������\r\n4)������������ ����� ��������� ������\r\n",
        "������� #2\r\n������:\r\n����� ����������� �� ��������:\r\n�������� ���� �� 4 ��������� ������:\r\n1)�������\r\n2)������� �������\r\n3)������� �������\r\n4)�������� �������\r\n",
        "������� #3\r\n������:\r\n�������� ���������� SQL ������ ��� ������� ����� ������ � ������� \"Persons\", ������ � ���� \"LastName\" �������� �������� \"Olsen\".\r\n�������� ���� �� 4 ��������� ������:\r\n1)�INSERT INTO Persons ('Olsen') INTO LastName\r\n2)�INSERT INTO Persons ('Olsen') VALUES LastName\r\n3)�INSERT INTO Persons (LastName) VALUES ('Olsen')\r\n4)�INSERT ('Olsen') INTO Persons (LastName)\r\n",
        "������� #4\r\n������:\r\n��� �������� �������� \"Hansen\" �� \"Nilsen\" � ������� \"LastName\", ������� Persons?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�MODIFY Persons SET LastName='Nilsen' WHERE LastName='Hansen'\r\n2)�MODIFY Persons SET LastName='Hansen' INTO LastName='Nilsen\r\n3)�UPDATE Persons SET LastName='Nilsen'�HAVING�LastName='Hansen'\r\n4)�UPDATE Persons SET LastName='Nilsen' WHERE LastName='Hansen'\r\n",
        "������� #5\r\n������:\r\n��� ������� ��� ������ �� ������� \"Persons\", ������������� �� ���� \"FirstName\" � �������� �������?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT * FROM Persons ORDER�BY�FirstName�ASC\r\n2)�SELECT * FROM Persons SORT�BY�'FirstName'�ACS\r\n3)�SELECT * FROM Persons ORDER 'FirstName' DESC\r\n4)�SELECT * FROM Persons ORDER BY FirstName DESC\r\n",
        "������� #6\r\n������:\r\n��� ������� ������, ��� �������� ���� \"FirstName\" ����� \"Peter\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�DELETE�FROM�FirstName='Peter' FROM Persons\r\n2)�DELETE FROM Persons WHERE FirstName = 'Peter'\r\n3)�DELETE FROM Persons WHILE�FirstName = 'Peter'\r\n4)�DELETE FirstName='Peter' FROM Persons\r\n",
        "������� #7\r\n������:\r\n������� SQL ��������������� ��� ������� ������ �� ����?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�EXTRACT\r\n2)�CREATE\r\n3)�OPEN\r\n4) �SELECT\r\n",
        "������� #8\r\n������:\r\n������� ����������� ���� ������ ��������:\r\n�������� ���� �� 4 ��������� ������:\r\n1)�������� �������\r\n2)����� �������\r\n3)������� �������\r\n4)��������������\r\n",
        "������� #9\r\n������:\r\n�������, �������� � ���������� �������� ���� ��������\r\n(��������� �����)\r\n��������� ����� �� ����:\r\nXCPETE -> __________________________________________\r\n",
        "������� #10\r\n������:\r\n��� ������� ��� ������ �� ������� \"Persons\", ��� �������� ���� \"FirstName\" ����� \"Peter\" � \"LastName\" ����� \"Jackson\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT * FROM Persons WHILE�FirstName='Peter' AND LastName='Jackson'\r\n2)�SELECT��FROM Persons WHERE FirstName�like�'Peter' AND LastName like�'Jackson'\r\n3)�SELECT * FROM Persons WHERE FirstName<>'Peter' AND LastName<>'Jackson'\r\n4)�SELECT * FROM Persons WHERE FirstName='Peter' AND LastName='Jackson'\r\n",
        "������� #11\r\n������:\r\n��������AVG���������\r\n�������� ���� �� 4 ��������� ������:\r\n1)�������� �������������� ��������\r\n2)�������� ������, ���� ����������� ���� �� ���� ������� �� ������ ������������\r\n3)������� ��������� ���������\r\n4)������������� ��������\r\n",
        "������� #12\r\n������:\r\n��� ������� ��� ������ �� ������� \"Persons\", ��� �������� ���� \"FirstName\" ����� \"Peter\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT * FROM Persons WHERE FirstName='Peter'\r\n2)�SELECT [all] FROM Persons WHERE FirstName LIKE 'Peter'\r\n3)�SELECT�DISTINCT�FROM Persons WHERE FirstName='Peter'\r\n4)�SELECT * FROM Persons WHERE FirstName<>'Peter'\r\n",
        "������� #13\r\n������:\r\nC�������� ���������� ���� �����SQL\r\n������� ������������ ��� ���� 5 ��������� ������:\r\n1)������� ������ ��� ��������, �� ������ ������� , ����������� ������\r\n2)�������� ������ ������\r\n3)������������ ����������� �� ���������� ����\r\n4)��������� ��� ����������� ������ � �������\r\n5)������� �����, �� ������� ��������������� ����� ������ � �������\r\n__�WHERE\r\n__�FROM\r\n__�GROUP BY\r\n__�ORDER BY\r\n__�HAVING\r\n",
        "������� #14\r\n������:\r\n��� ������� ��� ������ �� ������� \"Persons\", ��� �������� ���� \"FirstName\" ���������� � ����� \"a\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1) �SELECT * FROM Persons WHERE FirstName='a%'\r\n2)�SELECT * FROM Persons WHERE FirstName='*a*'\r\n3)�SELECT * FROM Persons WHERE FirstName�<>�'a*'\r\n4)�SELECT * FROM Persons WHERE FirstName LIKE 'a'\r\n",
        "������� #15\r\n������:\r\n����� ���ĠAccess, ������� �������� ��������������� �����������, �� �������\r\n�������� ���� �� 4 ��������� ������:\r\n1)��������\r\n2)���������\r\n3)���������\r\n4)����������\r\n",
        "������� #16\r\n������:\r\n����� SQL ��������� ������������ ��� ���������� ��������� ��������?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT DISTINCT\r\n2)�SELECT�INDEX\r\n3)�SELECT DIFFERENT\r\n4)�SELECT UNIQUE\r\n",
        "������� #17\r\n������:\r\n�������SQL���� ������� ���� ����� �� ������� \"Persons\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT *.Persons\r\n2)�SELECT Persons\r\n3)�SELECT�Any FROM�Persons\r\n4)�SELECT * FROM Persons\r\n",
        "������� #18\r\n������:\r\n��� ������� ��� ������ �� ������� \"Persons\", ��� �������� ���� \"LastName\" � ���������� ������� ��������� ����� ���������� \"Hansen\" � \"Pettersen\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT * FROM Persons WHERE LastName BETWEEN 'Hansen' AND 'Pettersen'\r\n2)�SELECT * FROM Persons WHERE LastName>'Hansen' AND LastName<'Pettersen'\r\n3)�SELECT�*�FROM Persons LastName>='Hansen' AND LastName<='Pettersen'\r\n4)�SELECT * FROM Persons WHERE LastName�ASC�'Hansen' AND 'Pettersen'\r\n",
        "������� #19\r\n������:\r\n����� ��� ����� ����� ��������� ����� ���� ������ ����������, ����� ���������� ��� ���� � ���������� �������\r\n�������� ���� �� 4 ��������� ������:\r\n1)������� �� ������\r\n2)����� �� ������\r\n3)�������\r\n4)����� � ������\r\n",
        "������� #20\r\n������:\r\n���� ������ ��������� �� ��������� ������ ����������... �\r\n(��������� �����)\r\n��������� ����� �� ����:\r\n����������� -> __________________________________________\r\n",
        "������� #21\r\n������:\r\n��������� �������� � ��������\r\n������� ������������ ��� ���� 3 ��������� ������:\r\n1)�������� �������\r\n2)��������� �������\r\n3)�������� �������\r\n__�CREATE TABLE\r\n__�ALTER TABLE\r\n__�DROP TABLE\r\n������� #21\r\n������:\r\n��������� �������� � ��������\r\n������� ������������ ��� ���� 3 ��������� ������:\r\n1)�������� �������\r\n2)��������� �������\r\n3)�������� �������\r\n__�CREATE TABLE\r\n__�ALTER TABLE\r\n__�DROP TABLE\r\n",
        "������� #22\r\n������:\r\n�������� ���������� SQL ������ ��� ������� ����� ������ � ������� \"Persons\".\r\n�������� ���� �� 4 ��������� ������:\r\n1)�INSERT INTO Persons�(name, lasname)�VALUES ('Jimmy', 'Jackson')\r\n2)�INSERT ('Jimmy', 'Jackson') INTO Persons\r\n3)�INSERT VALUES ('Jimmy', 'Jackson') INTO Persons\r\n4)�INSERT INTO Persons VALUES ('Jimmy', 'Jackson')\r\n",
        "������� #23\r\n������:\r\n������������ ����������� �������� � ���ĠAccess\r\n������� ������������ ��� ���� 6 ��������� ������:\r\n1)��������� ������ �� ��� �������� ������\r\n2)������� ��������������� ��� ��������� ����������\r\n3)����� ����� ������ ��� �������� ���������\r\n4)������� ���������� �� ������� � ������� � ��������� ����\r\n5)�� ������� ����������� ���������������� ������� ������ � ��\r\n6)������������ ��������� ���������� �� �����Visual Basic (VB)\r\n__��������\r\n__��������\r\n__�������\r\n__�������\r\n__��������\r\n__������\r\n",
        "������� #24\r\n������:\r\n��� ������ ���ĠAcces, � ������� ����� ������� �������, ����� � ������ �������������� �������\r\n�������� ���� �� 4 ��������� ������:\r\n1)�����\r\n2)���������\r\n3)�����������\r\n4)�OLE\r\n",
        "������� #25\r\n������:\r\n����� ��� ����� ����� ��������� ����� ���� ������ ����������, ����� ���������� ���� � ��������� ������ � ����� ��� �����\r\n�������� ���� �� 3 ��������� ������:\r\n1)����� � ������\r\n2)����� �� ������\r\n3)������� �� ������\r\n",
        "������� #26\r\n������:\r\n��� ���������������� SQL?\r\n�������� ���� �� 4 ��������� ������:\r\n1)������������������ ���� ��������\r\n2)�������� ���������� ��������\r\n3) ��������-�������� �����\r\n4)������������������ ���� ��������\r\n",
        "������� #27\r\n������:\r\n��������� ����SQL�������� ������� � �� � ��������� \"FirstName\" �� ������� \"Persons\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�CREATE�FirstName�ON�Persons\r\n2)�SELECT Persons.FirstName\r\n3)�SELECT FirstName FROM Persons\r\n4)�EXTRACT FirstName FROM Persons\r\n",
        "������� #28\r\n������:\r\n��� ������� ���������� �������, ���������� � ������� \"Persons\"?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�SELECT COLUMNS() FROM Persons\r\n2)�SELECT COUNT() FROM Persons\r\n3)�SELECT COUNT(*) FROM Persons\r\n4)�SELECT COUNT(Persons)\r\n",
        "������� #29\r\n������:\r\nSQL ������� ��� �������������� �����������?\r\n�������� ���� �� 4 ��������� ������:\r\n1)�ORDER\r\n2)�ORDER BY\r\n3)�SORT\r\n4)�SORT BY\r\n",
        "������� #30\r\n������:\r\n���������\r\n������� ������������ ��� ���� 4 ��������� ������:\r\n1)��������� ���������\r\n2)�������� ������ � �������\r\n3)��������� ������ � �������\r\n4)��������� ��������\r\n__�INSERT\r\n__�DELETE\r\n__�UPDATE\r\n__�ROLLBACK\r\n"

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
