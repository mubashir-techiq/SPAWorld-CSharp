using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SPA_World_new
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 71; j++)
                {
                    
                    if (
                        /*S*/ (j == 5 && (i != 7 && i != 8 && i != 10)) || (j == 6 && (i != 7 && i != 8)) || (j == 7 && (i != 3 && i != 4 && i != 7 && i != 8)) || (j == 8 && (i != 3 && i != 4)) || (j == 9 && (i != 3 && i != 4 && i != 1)) ||
                        /*P*/ (j == 12 || j == 13) || (j == 14 && (i == 1 || i == 2 || i == 5 || i == 6)) || (j == 15 && (i == 1 || i == 2 || i == 5 || i == 6)) || (j == 16 && i < 7) || (j == 17 && i < 6 && i > 1) ||
                        /*A*/ (j == 20 && i != 1) || (j == 21) || (j == 22 && i != 4 && i != 3 && i < 6) || (j == 23) || (j == 24 && i != 1) ||
                        /*W*/ (j == 29) || (j == 30) || (j == 31 && i > 8) || (j == 32 && i > 7 && i < 10) || (j == 33 && i > 6 && i < 9) || (j == 34 && i > 7 && i < 10) || (j == 35 && i > 8) || (j == 36) || (j == 37) ||
                        /*O*/ (j == 40 && i > 1 && i < 10) || (j == 41) || (j == 42 && (i == 1 || i == 2 || i == 9 || i == 10)) || (j == 43 && (i == 1 || i == 2 || i == 9 || i == 10)) || (j == 44) || (j == 45 && i > 1 && i < 10) ||
                        /*R*/ (j == 48) || (j == 49) || (j == 50 && (i != 3 && i != 4 && i < 7)) || (j == 51 && i != 3 && i != 4 && i < 9) || (j == 52 && i != 3 && i != 4 && i != 7 && i != 10) || (j == 53 && i != 7 && i != 8) || (j == 54 && (i != 1 && i != 6 && i != 7 && i != 8 && i != 9)) ||
                        /*L*/ (j == 57) || (j == 58) || (j == 59 && i > 8) || (j == 60 && i > 8) || (j == 61 && i > 8) || (j == 62 && i > 8) ||
                        /*D*/ (j == 65) || (j == 66) || (j == 67 && (i < 3 || i > 8)) || (j == 68 && (i < 3 || i > 8)) || (j == 69) || (j == 70 && i != 1 && i != 10) 
                        ) 
                    {
                        Console.Write("*");
                    }
                    else if (j <= 3)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tPress c to Continue");
        a: char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException) 
        {
            Console.WriteLine("Enter a Single Character");
            goto a;
        }

        if (c == 'c' || c == 'C')
            {
                //AdminOptions();
                //customeroptions(1234);
                typeofInput();
            }
            else
            {
                goto a;
            }

            Console.ReadLine();
        }

        static void typeofInput()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                               Type of Login");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Which type of login do you want?\n\t1) Admin\n\t2) Worker\n\t3) Customer");
            Console.WriteLine("Press any option to continue");
        start: char a;
        try
        {
            a = Convert.ToChar(Console.ReadLine());

        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto start;
        }
            if (a == '1')
            {
                Adminsignuporlogin();

            }
            else if (a == '2')
            {
                Workersignuporlogin();
            }
            else if (a == '3')
            {
                Customersignuporlogin();
            }
            else
            {
                Console.WriteLine("Enter a Valid Option");
                goto start;
            }
        }

        // Admin Position
        static void Adminsignuporlogin()
        {
            Console.Clear();

            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                                Admin Login");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
        uid: Console.Write("Enter Userid:");
         int Uid;
        try
        {
            Uid = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only Integer");
            goto uid;
        }
             
            Console.Write("Enter Password:");
        pas: string pass = Console.ReadLine();
        bool chkuid = false,chkpass =false;
        if (65097 == Uid)
        {
            chkuid = true;
        }
        if (pass == "admin123")
        {
            chkpass = true;
        }
        if (chkuid == false)
        {
            Console.WriteLine("Invalid User ID");
            goto uid;
        }
        else if (chkpass == false) 
        {
            Console.WriteLine("Invalid Password, Enter Again");
            goto pas;
        }
            else
            {
                AdminOptions();
            }
        }

        static void AdminOptions()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Admin Options");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Press the required Keys to Open the Following Options:");
            Console.WriteLine("\tPress w for Worker Options" +
                "\n\tPress a for Approving Customer Appointments"
                + "\n\tPress s for Services Options" +
                "\n\tPress p for Checking Profit and Loss of Saloon"
                + "\n\tPress x to Logout");
            Console.Write("Enter Here: ");
        abc: char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto abc;
        }
             
        if (c == 'w' || c == 'W')
            {
                workeropti();
            }
        else if (c == 'a' || c == 'A')
            {
                appointmentapproval();
            }
        else if (c == 's' || c == 'S')
            {
                servicesopt();
            }
        else if (c == 'p' || c == 'P')
            {
                profitandloss();
            }
        else if (c == 'x' || c == 'X')
            {
                typeofInput();
            }
            else
            {
                Console.WriteLine("Enter a Valid Character Again!");
                goto abc;
            }
        }

        static void workeropti()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                         Admin Options for Workers");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Press the Required keys to Access the options"
                + "\n\tPress a to Add or Remove a Worker"
                + "\n\tPress d to get the Details of all Workers"
                + "\n\tPress r to Check the Reviews any Employ"
                + "\n\tPress s to Manage the Salary of any Worker"
                + "\n\tPress b to go back ");
            Console.Write("Enter Here: ");
        abc: char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto abc;
        }
        if (c == 'a' || c == 'A')
            {
                addorRemoveWorker();
            }
        else if (c == 'd' || c == 'D')
            {
                workerdetail();
            }
        else if (c == 'r' || c == 'R')
            {
                workerreview();
            }
        else if (c == 's' || c == 'S')
            {
                workersalary();
            }
        else if (c == 'b' || c == 'B')
            {
                AdminOptions();
            }
            else
            {
                Console.WriteLine("Enter a Valid Character, Again!");
                goto abc;
            }

        }

        static void addorRemoveWorker() 
        {
            Console.Clear();
            Console.WriteLine("Press the Required Option to Access the functionality:"
                + "\n\tPress 1 to Add/SignUp a Worker"
                + "\n\tPress 2 to Remove a Worker"
                + "\n\tPress 3 to go back");
            Console.Write("Enter Here: ");
        abc: char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto abc;
        }
            if (c == '1')
            {
                signupworker();
            }
            else if (c == '2')
            {
                removeworker();
            }
            else if (c == '3')
            {
                workeropti();
            }
            else
            {
                Console.WriteLine("Enter a Valid Character, Again!");
                goto abc;
            }
        }

        static void signupworker()
        {
            Console.Clear();
            Console.Write("Enter Worker Name: ");
            string name = Console.ReadLine();

        mail: Console.Write("Enter Worker Email: ");
            string email = Console.ReadLine();

            bool chkmail = false;
            foreach (char a in email)
            {
                if (a == '@')
                {
                    chkmail = true;
                }
            }
            if (chkmail == false)
            {
                Console.WriteLine("Enter a valid Email Address!");
                goto mail;
            }

        nic: Console.Write("Enter Worker CNIC: ");
            long nic;
            try
            {
                nic = Convert.ToInt64(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto nic;
            }
            
            if (nic.ToString().Length != 13)
            {
                Console.WriteLine("Enter a Valid CNIC Number");
                goto nic;
            }

        cont: Console.Write("Enter Contact No.: ");
            long contact;
            try
            {
                contact = Convert.ToInt64(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto cont;
            }

            if (contact.ToString().Length != 10)
            {
                Console.WriteLine("Enter a Valid Contact Number");
                goto cont;
            }
            sal:Console.Write("Enter Salary of Worker: ");
            int sal;
            try
            {
                sal = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto sal;
            }
        pass: Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

           if (pass.Length < 8) 
           {
               Console.WriteLine("Password should be greater than or equal to 8 digits");
               goto pass;
           }
        id: Console.Write("Enter 4-Digit Worker ID: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
            if(id.ToString().Length != 4)
            {
                Console.WriteLine("ID should be of 4 Digits");
                goto id;
            }

            int error = 0;
            signup(name, contact, email, pass, id, "workerdetail.txt", ref error, nic, sal);

            if (error == 1)
            {
                Console.WriteLine("The given Worker ID already exists, Please enter again");
                goto id;
            }
            else
            {
                Console.WriteLine("SignIn Successfull!");
            c: Console.WriteLine("Press any key to continue");
                try
                {
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    goto c;
                }
                AdminOptions();
            }
        }

        static void removeworker()
        {
            Console.Clear();
            Console.WriteLine("To Remove a Worker You need to Enter ID of that Worker and Press r to Remove him or you can also press b to go back without removing");
            Console.WriteLine();
            string[] name = {"Worker Name: ","Worker ID:"};
            int[] i = {2,0};
            showlist("workerdetail.txt",name,i);
        id: Console.Write("Enter Worker ID: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
        c: Console.Write("Press r to Remove or b to go back: ");
        char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto c;
        }
            if (c == 'r' || c == 'R')
            {
                bool chk = false;
                deletesomething("workerdetail.txt", ref chk, id.ToString(), 0);
                if (chk == false)
                {
                    Console.WriteLine("This id does not Exist\nDo You want to Enter again\n\tPress y for Yes\n\tPress n for No");
                    Console.Write("Enter Here: ");
                abc: char yn;
                    try
                    {
                        yn = Convert.ToChar(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a Single Character");
                        goto abc;
                    }
                    if (yn == 'y' || yn == 'Y')
                    {
                        goto id;
                    }
                    else if (yn == 'n' || yn == 'N')
                    {
                        addorRemoveWorker();
                    }
                }
                else
                {
                    Console.WriteLine("Worker Removed Successfully!");
                ca: Console.WriteLine("Press any key to continue");
                    try
                    {
                        Console.ReadKey();
                    }
                    catch (FormatException)
                    {
                        goto ca;
                    } 
                    AdminOptions();

                }
            }
            else if (c == 'b' || c == 'B')
            {
                addorRemoveWorker();
            }
            else
            {
                goto c;
            }

        }

        static void workerdetail()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                              Worker Details");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.Write("Total Number of Workers: ");
            int c = 0;
            using (StreamReader sr = new StreamReader("workerdetail.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    c++;
                }
            }

            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine("What type of Data do you want to get?\n\tPress n for Name\n\tPress e for Email\n\tPress c for CNIC No. \n\tPress i to Search all details for a specific id\n\tPress b to go Back");
            Console.Write("Enter Here: ");
        abc: char t;
        try
        {
            t = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto abc;
        }
            if (t == 'b' || t == 'B')
            {
                workeropti();
            }
            else if (t == 'i' || t == 'I')
            {
                Console.WriteLine();
                string[] name = { "Worker Name: ", "Worker ID:" };
                int[] it = { 2, 0 };
                showlist("workerdetail.txt", name, it);

                using (StreamReader sr = new StreamReader("workerdetail.txt"))
                {
                id:Console.Write("Enter Worker ID:");
                    int id;
                    try
                    {
                        id = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only Integer");
                        goto id;
                    }
                    string line;
                    bool chk = false;
                    string[] dataname = { "ID: ", "Password: ", "Name: ", "Email: ", "Contact: ", "CNIC No.: ","Salary: ", "Review: " };
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (id == Convert.ToInt32(data[0]))
                        {
                            for (int i = 0; i < data.Length; i++)
                            {
                                Console.WriteLine(dataname[i] + data[i]);
                            }
                            chk = true;
                        }
                    }
                    if (chk == false)
                    {
                        Console.WriteLine("The ID you entered Doesn't Exist");
                    ca: Console.WriteLine("Press any key to continue");
                        try
                        {
                            Console.ReadKey();
                        }
                        catch (FormatException)
                        {
                            goto ca;
                        } 
                        workerdetail();
                    }
                    else
                    {
                    ca: Console.WriteLine("Press any key to continue");
                        try
                        {
                            Console.ReadKey();
                        }
                        catch (FormatException)
                        {
                            goto ca;
                        } 
                        workerdetail();
                    }
                }
            }
            else if (t == 'n' || t == 'N' || t == 'e' || t == 'E' || t == 'c' || t == 'C')
            {
                finder(t);
            }
            else
            {
                Console.WriteLine("Enter a Valid Character! Again");
                goto abc;
            }
        }
        static void finder(char t)
        {
            using (StreamReader sr = new StreamReader("workerdetail.txt"))
            {
                int index = 0;
                string value = "";
                if (t == 'n' || t == 'N')
                {
                    index = 2;
                    value = "Names";
                }
                else if (t == 'e' || t == 'E')
                {
                    index = 3;
                    value = "Emails";
                }
                else if (t == 'c' || t == 'C')
                {
                    index = 5;
                    value = "CNIC No.s";
                }
                string line;
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t**********************{0}***************************", value);
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    Console.WriteLine("\t" + data[index]);
                }
            ca: Console.WriteLine("Press any key to continue");
                try
                {
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    goto ca;
                } 
                workerdetail();
            }
        }

        static void workerreview()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Worker Review");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            string[] name = { "Worker Name: ", "Worker ID:" };
            int[] i = { 2, 0 };
            showlist("workerdetail.txt", name, i);
            Console.WriteLine();
            id:Console.Write("Enter Worker ID: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
            Console.Clear();

            Console.WriteLine("\t\t\t                         **********************                         ");
            Console.WriteLine("\t\t\t                            Worker Ratings");
            Console.WriteLine("\t\t\t                         **********************                         ");
            Console.WriteLine();

            bool chk = false;
            using (StreamReader srw = new StreamReader("workerdetail.txt"))
            {
                string line;
                while ((line = srw.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    if (id == Convert.ToInt32(data[0]))
                    {
                        if (File.Exists("workers/" + id.ToString() + ".txt"))
                        {
                            using (StreamReader sr = new StreamReader("workers/reviews/" + id.ToString() + ".txt"))
                            {
                                string lines;
                                while ((lines = sr.ReadLine()) != null)
                                {
                                    string[] datas = lines.Split('|');
                                    Console.WriteLine("Rating : [{0}], {1} by {2}", datas[0], datas[1], datas[2]);
                                    Console.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("This Worker has No Reviews");
                        }
                    ca: Console.WriteLine("Press any key to continue");
                        try
                        {
                            Console.ReadKey();
                        }
                        catch (FormatException)
                        {
                            goto ca;
                        } 
                        workeropti();
                        chk = true;
                    }
                }
            }
            if (chk == false)
            {
                Console.WriteLine("This ID does not Exist");
                Console.WriteLine("Press any Key to Continue Again or press b to go back");
            abc: char c;
            try
            {
                c = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a Single Character");
                goto abc;
            }
                if (c == 'b' || c == 'B')
                {
                    workeropti();
                }
                else
                {
                    workerreview();
                }
            }

        }

        static void workersalary()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Worker Salary");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();

            string[] dataname = { "ID: ", "Name: ", "Salary: " };
            int[] specificdata = { 0, 2, 6 };
            showlist("workerdetail.txt", dataname, specificdata);

            id:Console.Write("Enter Worker ID: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
            bool upchk = false;
            using (StreamReader sr = new StreamReader("workerdetail.txt"))
            {
                string line;
                bool chk = false;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    if (id == Convert.ToInt32(data[0]))
                    {
                        Console.WriteLine("ID: " + data[0]);
                        Console.WriteLine("Name: " + data[2]);
                        Console.WriteLine("Salary: " + data[6]);
                        Console.WriteLine("Press  u to Update Salary\nPress b to go Back");
                    abc: char k ;
                    try
                    {
                        k = Convert.ToChar(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a Single Character");
                        goto abc;
                    }
                        if (k == 'u' || k == 'U')
                        {
                            upchk = true;
                        }
                        else if (k == 'b' || k == 'B')
                        {
                            workeropti();
                        }
                        else
                        {
                            Console.WriteLine("Press a valid Key");
                            Console.WriteLine("Press Again");
                            goto abc;
                        }
                        chk = true;
                        break;
                    }
                }
                if (chk == false)
                {
                    Console.WriteLine("The id You entered doesn't Exist");
                    Console.WriteLine("Press b to go back or Press any key to try again");
                abc:char key;
                try
                {
                    key = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a Single Character");
                    goto abc;
                }
                    if (key == 'b' || key == 'B')
                    {
                        workeropti();
                    }
                    else
                    {
                        workersalary();
                    }
                }
            }

            if (upchk == true)
            {
                updatesalary(id);
            }
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            workeropti();

        }
        static void updatesalary(int id)
        {
            sal:Console.Write("Enter New Salary: ");
            int sal;
            try
            {
                sal = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto sal;
            }
            updatesomething("workerdetail.txt", id.ToString(), 0, 6, sal.ToString());
        }

        static void appointmentapproval()
        {
            int code = 0;
            string appid = "";
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                        Appointments to be Approved");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            bool pend = false;
            if (File.Exists("appointments.txt"))
            {
                using (StreamReader sr = new StreamReader("appointments.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        string[] dataname = { "Apointment ID: ", "Customer ID: ", "Worker ID: ", "Customer Name: ", "Worker Name: ", "Service: ", "Price: ", "Review: ", "Review Message: ", "Time: ", "Day: ", "Status: " };
                        if (data[11] == "Pending")
                        {
                            pend = true;
                            for (int i = 0; i < data.Length; i++)
                            {
                                Console.WriteLine(dataname[i] + data[i]);
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
                if (pend == true)
                {
                    Console.Write("Enter Appointment ID to Access the Appointment: ");
                id: int id;
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only Integer");
                    goto id;
                }
                    bool chk = false;
                    using (StreamReader sr = new StreamReader("appointments.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data[0] == id.ToString())
                            {
                                if (data[11] == "Pending")
                                {
                                    appid = data[0];
                                    Console.Clear();
                                    Console.WriteLine("Press the Option\n\tPress 1 to Approve\n\tPress 2 to Reject");
                                a: int a;
                                try
                                {
                                    a = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Enter only Integer");
                                    goto a;
                                }
                                    if (a == 1)
                                    {
                                        code = 1;
                                    }
                                    else if (a == 2)
                                    {
                                        code = 2;
                                    }
                                    else
                                    {
                                        goto a;
                                    }
                                    chk = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (code == 1)
                    {
                        approveappointment(appid);
                    }
                    else if (code == 2)
                    {
                        rejectappointment(appid);
                    }
                    if (chk == false)
                    {
                        Console.WriteLine("This Appointment ID does not Exists, Enter Again: ");
                        goto id;
                    }
                }
                else
                {
                    Console.WriteLine("There are no Appointments to be approved");
                ca: Console.WriteLine("Press any key to continue");
                    try
                    {
                        Console.ReadKey();
                    }
                    catch (FormatException)
                    {
                        goto ca;
                    } 
                    AdminOptions();
                }
            }
            else
            {
                Console.WriteLine("There are no Appointments to be approved");
            ca: Console.WriteLine("Press any key to continue");
                try
                {
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    goto ca;
                } 
                AdminOptions();
            }
        }
        static void approveappointment(string aid)
        {
            Console.Clear();
            int wid = 0;
            string wname = " ", cname = "", service = "", price = "", time = "", day = "", cid = "";
            using (StreamReader sr = new StreamReader("workerdetail.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    for (int i = 0; i <= 2; i++)
                    {
                        if (i != 1)
                        {
                            Console.WriteLine(data[i]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

        wid: Console.Write("Enter Worker ID: ");
         try
         {
             wid = Convert.ToInt32(Console.ReadLine());
         }
         catch (FormatException)
         {
             Console.WriteLine("Enter only Integer");
             goto wid;
         }

            using (StreamReader sr = new StreamReader("workerdetail.txt"))
            {
                bool chk = false;
                string nline;
                while ((nline = sr.ReadLine()) != null)
                {
                    string[] data = nline.Split('|');
                    if (wid.ToString() == data[0])
                    {
                        wname = data[2];
                        chk = true;
                    }
                }
                if (chk == false)
                {
                    Console.WriteLine("This id does not exist, Enter Again: ");
                    goto wid;
                }

            }
            validatedaytime(ref time, ref day);

            if (File.Exists("workers/appointments/" + wid.ToString() + ".txt"))
            {
                using (StreamReader sr = new StreamReader("workers/appointments/" + wid.ToString() + ".txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[7] == time && data[8] == day)
                        {
                            Console.WriteLine("This Worker is busy on the given Time slot and day Please Choose another worker");
                            Console.WriteLine("Press any key to choose another worker or press r to reject it");
                        abc:char r;
                        try
                        {
                            r = Convert.ToChar(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Enter a Single Character");
                            goto abc;
                        }
                            if (r == 'r' || r == 'R')
                            {
                                rejectappointment(aid);
                            }
                            else
                            {
                                goto wid;
                            }

                        }
                    }
                }
            }
            updatesomething("appointments.txt", aid.ToString(), 0, 2, wid.ToString());
            updatesomething("appointments.txt", aid.ToString(), 0, 4, wname);
            updatesomething("appointments.txt", aid.ToString(), 0, 11, "Approved");
            updatesomething("appointments.txt", aid.ToString(), 0, 7, time);
            updatesomething("appointments.txt", aid.ToString(), 0, 8, day);

            findsomething("appointments.txt", 0, aid.ToString(), ref cname, 3);
            findsomething("appointments.txt", 0, aid.ToString(), ref service, 5);
            findsomething("appointments.txt", 0, aid.ToString(), ref price, 6);
            findsomething("appointments.txt", 0, aid.ToString(), ref cid, 1);

            if (File.Exists("customers/appointments/" + cid.ToString() + ".txt"))
            {
                updatesomething("customers/appointments/" + cid.ToString() + ".txt", aid.ToString(), 0, 2, wid.ToString());
                updatesomething("customers/appointments/" + cid.ToString() + ".txt", aid.ToString(), 0, 4, wname);
                updatesomething("customers/appointments/" + cid.ToString() + ".txt", aid.ToString(), 0, 11, "Approved");
                updatesomething("customers/appointments/" + cid.ToString() + ".txt", aid.ToString(), 0, 7, time);
                updatesomething("customers/appointments/" + cid.ToString() + ".txt", aid.ToString(), 0, 8, day);

            }

            using (StreamWriter sw = new StreamWriter("workers/appointments/" + wid.ToString() + ".txt", append: true))
            {
                sw.WriteLine("{0}|{1}|{2}|{3}|{4}| | |{5}|{6}|Approved", aid, cid, cname, service, price, time, day);
            }

            Console.WriteLine("Appointment Approved Successfully");
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            AdminOptions();
        }
        static void validatedaytime(ref string time, ref string day)
        {

            Console.WriteLine("Enter Time Slot:\n\tPress 1 for 12:00AM to 2:00PM Time Slot\n\tPress 2 for 3:00PM to 5:00PM Time Slot\n\tPress 3 for 6:00PM to 8:00PM Time Slot");
            Console.Write("Enter Here: ");

        t: char t;
        try
        {
            t = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto t;
        }
            if (t == '1')
            {
                time = "12:00 AM";
            }
            else if (t == '2')
            {
                time = "3:00 AM";
            }
            else if (t == '3')
            {
                time = "6:00 AM";
            }
            else
            {
                Console.WriteLine("Enter a valid Time slot, Enter again!");
                goto t;
            }

            Console.WriteLine("Enter Day:\n\tPress 1 for Monday\n\tPress 2 for Tuesday\n\tPress 3 for Wednessday\n\tPress 4 for Thursday\n\tPress 5 for Saturday");
            Console.Write("Enter Here: ");
        d: char d;
        try
        {
            d = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto d;
        }
            if (d == '1')
            {
                day = "Monday";
            }
            else if (d == '2')
            {
                day = "Tuesday";
            }
            else if (d == '3')
            {
                day = "Wednessday";
            }
            else if (d == '4')
            {
                day = "Thursday";
            }
            else if (d == '5')
            {
                day = "Saturday";
            }
            else
            {
                Console.WriteLine("Enter a valid day, Enter again!");
                goto d;
            }

        }
        static void rejectappointment(string aid)
        {
            Console.Clear();
            string cid = "";
            updatesomething("appointments.txt", aid, 0, 11, "Rejected");
            findsomething("appointments.txt", 0, aid, ref cid, 1);

            updatesomething("customers/appointments/" + cid + ".txt", aid, 0, 11, "Rejected");

            Console.WriteLine("This Appointment has been Rejected");
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            AdminOptions();
        }


        static void servicesopt()
        {
            Console.Clear();
            Console.WriteLine("Press the Required options to Access it"
                + "\n\tPress a to Add a Service"
                + "\n\tPress r to Remove a Service"
                + "\n\tPress u to Update a Service"
                + "\n\tPress b to go back");
            Console.Write("Enter Here: ");
        c: char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto c;
        }

            if (c == 'a' || c == 'A')
            {
                addservice();
            }
            else if (c == 'r' || c == 'R')
            {
                removeservice();
            }
            else if (c == 'u' || c == 'U')
            {
                updateservice();
            }
            else if (c == 'b' || c == 'B')
            {
                AdminOptions();
            }
            else
            {
                Console.WriteLine("Enter a valid Character Again : ");
                goto c;
            }
        }

        static void addservice()
        {
            Console.Clear();
            Console.Write("Enter Service Name: ");
            string sname = Console.ReadLine();

            sp:Console.Write("Enter Service Price: ");
            int sprice;
            try
            {
                sprice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto sp;
            }
            Console.WriteLine("Enter gender for this Service:\n\tPress 1 For Male\n\tPress 2 for Female\n\tPress 3 for both");
            Console.Write("Enter Here: ");
            abc:char g ;
            try
            {
                g = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a Single Character");
                goto abc;
            }
            Random r = new Random();
        sid: int sid = r.Next(1000, 9999);

            if (File.Exists("services.txt"))
            {
                using (StreamReader sr = new StreamReader("services.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[0] == sid.ToString())
                        {
                            goto sid;
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("services.txt", append: true))
            {
                sw.WriteLine("{0}|{1}|{2}|{3}", sid, sname, sprice, g);
            }
            Console.WriteLine("Service added Successfully");
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            AdminOptions();
        }

        static void removeservice()
        {
            Console.Clear();
            using (StreamReader sr = new StreamReader("services.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dataname = { "Service ID: ", "Service Name: ", "Service Price: ", "Service Gender: " };
                    string[] data = line.Split('|');
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i] == "1")
                        {
                            Console.WriteLine(dataname[i] + "Male");
                        }
                        else if (data[i] == "2")
                        {
                            Console.WriteLine(dataname[i] + "Female");
                        }
                        else if (data[i] == "3")
                        {
                            Console.WriteLine(dataname[i] + "Male/Female");
                        }
                        else
                        {
                            Console.WriteLine(dataname[i] + data[i]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            sid:Console.Write("Enter Service ID: ");
            int sid;
            try
            {
                sid = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto sid;
            }
            bool chk = false;

            deletesomething("services.txt", ref chk, sid.ToString(), 0);
            if (chk == false)
            {
                Console.WriteLine("This id does not Exist");

            }
            else
            {
                Console.WriteLine("Service Removed Successfully");
            }
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            AdminOptions();
        }

        static void updateservice()
        {
            string sname = "";
            char g = '.';
            int sprice = 0;
            Console.Clear();
            using (StreamReader sr = new StreamReader("services.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dataname = { "Service ID: ", "Service Name: ", "Service Price: ", "Service Gender: " };
                    string[] data = line.Split('|');
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i] == "1")
                        {
                            Console.WriteLine(dataname[i] + "Male");
                        }
                        else if (data[i] == "2")
                        {
                            Console.WriteLine(dataname[i] + "Female");
                        }
                        else if (data[i] == "3")
                        {
                            Console.WriteLine(dataname[i] + "Male/Female");
                        }
                        else
                        {
                            Console.WriteLine(dataname[i] + data[i]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            sid:Console.Write("Enter Service ID: ");
            int sid;
            try
            {
                sid = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto sid;
            }
            Console.WriteLine("Which Property do you want to Update:\n\tPress n to Update Serice Name\n\tPress p to Update Service Price\n\tPress g to Update Service Gender");
            Console.Write("Enter Here: ");
        a: char p;
        try
        {
            p = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto a;
        }

        if (p == 'n' || p == 'N')
            {
                Console.Clear();
                Console.Write("Enter new Service Name: ");
                sname = Console.ReadLine();
            }
        else if (p == 'p' || p == 'P')
            {
                Console.Clear();
        sp:Console.Write("Enter new Service Price: ");
        try
        {
            sprice = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only Integer");
            goto sp;
        }
            }
        else if (p == 'g' || p == 'G')
            {
                Console.Clear();
                Console.WriteLine("Enter new gender for Service:\n\tPress 1 For Male\n\tPress 2 for Female\n\tPress 3 for both");
        abc:Console.Write("Enter Here: ");
                try
                {
                    g = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a Single Character");
                    goto abc;
                } 
            }
            else
            {
                Console.WriteLine("Enter a Valid Character Again: ");
                goto a;
            }
            bool chk = false;
            using (StreamReader sr = new StreamReader("services.txt"))
            {
                using (StreamWriter sw = new StreamWriter("temp.txt"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[0] == sid.ToString())
                        {
                            if (p == 'n' || p == 'N')
                            {
                                data[1] = sname;
                            }
                            else if (p == 'p' || p == 'P')
                            {
                                data[2] = sprice.ToString();
                            }
                            else if (p == 'g' || p == 'G')
                            {
                                data[3] = g.ToString();
                            }
                            sw.WriteLine("{0}|{1}|{2}|{3}", data[0], data[1], data[2], data[3]);
                            chk = true;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }

                }
            }
            File.Delete("services.txt");
            File.Move("temp.txt", "services.txt");
            if (chk == false)
            {
                Console.WriteLine("This id does not Exist");

            }
            else
            {
                Console.WriteLine("Service Updated Successfully");
            }
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            AdminOptions();
        }

        static void profitandloss()
        {
            Console.Clear();
            int profit = 0;
            Console.WriteLine("Your Comapany Profit is: ");
            Console.WriteLine("Your Total Appointments in the SPA are: ");
            Console.WriteLine();
            string[] dtname = {"Appointment ID: ","Customer ID: ","Worker ID: ","Customer Name: ","Worker Name: ","Service: ","Price: ","Time: ","Day: ","Rating: ","Review: ","Status: " };
            using (StreamReader sr = new StreamReader("appointments.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    if (data[11] == "Completed")
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            if (i == 6 && data[i] != " ")
                            {
                                profit += Convert.ToInt32(data[i]);
                            }
                            Console.WriteLine(dtname[i] + data[i]);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
            Console.Write("The Profit from these appointments is:");
            Console.WriteLine(profit);
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            AdminOptions();
        }

        // Worker Position
        static void Workersignuporlogin()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Worker Login");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
        uid: Console.Write("Enter Userid:");
            int uid;
            try
            {
                uid = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto uid;
            }
            pas: Console.Write("Enter Password:");
            string pass = Console.ReadLine();
            int error = 0;
            login(uid, pass, ref error, "workerdetail.txt");
            if (error == 1)
            {
                Console.WriteLine("Invalid User ID");
                goto uid;
            }
            else if (error == 2)
            {
                Console.WriteLine("Invalid Password, Enter Again");
                goto pas;
            }
            else
            {
                WorkerOptions(uid);
            }

        }

        static void WorkerOptions(int wid)
        {
            Console.Clear();
            Console.WriteLine("Press the required keys to Access Options below"
                + "\n\tPress a to Check Appointed Customers"
                + "\n\tPress c to Bill your Customers"
                + "\n\tPress r to Check Your Reviews"
                + "\n\tPress x to Logout");
            Console.Write("Enter Here: ");
        abc: char c;
        try
        {
            c = Convert.ToChar(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a Single Character");
            goto abc;
        }
            if (c == 'a' || c == 'A')
            {
                AppointedCustomers(wid);
            }
            else if (c == 'c' || c == 'C')
            {
                billCustomers(wid);
            }
            else if (c == 'x' || c == 'X')
            {
                typeofInput();
            }
            else if (c == 'r' || c == 'R') 
            {
                workerrev(wid);
            }
            else
            {
                Console.WriteLine("Enter a Valid Character Again!");
                goto abc;
            }

        }

        static void workerrev(int wid) 
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Your Reviews");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            string[] dtname = {"Customer Name: ","Service: ","Rating: ","Review: "};
            int[] dtindex = {2,3,5,6};
            bool chk = false;
            using (StreamReader sr = new StreamReader("workers/appointments/" + wid.ToString() + ".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    if (data[5] != " ") 
                    {
                        chk = true;
                    }
                }
            }
            if (chk == true)
            {
                
                string file = "workers/appointments/" + wid.ToString() + ".txt";
                if (File.Exists(file))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data[5] != " ")
                            {
                                for (int i = 0; i < dtindex.Length; i++)
                                {
                                    if (data[dtindex[i]] != " ")
                                    {
                                        Console.WriteLine(dtname[i] + data[dtindex[i]]);
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                         }
                        }
                    }
                Console.WriteLine();
                string rat = "0";
                findsomething("workerdetail.txt", 0, wid.ToString(),ref rat, 7);
                Console.WriteLine("Your total Rating is: " + rat);
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("You don't Have any Reviews for Now");
            }
            Console.WriteLine("Press any key to Continue");
            a:try
            {
                Console.ReadKey();
            }
            catch (FormatException) 
            {
                Console.WriteLine("Press valid key");
                goto a;
            }
            WorkerOptions(wid);
        }

        static void AppointedCustomers(int wid)
        {
            Console.Clear();
            bool chk = false;
            if (File.Exists("workers/appointments/" + wid.ToString() + ".txt"))
            {

                using (StreamReader sr = new StreamReader("workers/appointments/" + wid.ToString() + ".txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[9] == "Approved")
                        {
                            chk = true;
                        }
                    }
                }
            }
            if (chk == true)
            {
                Console.WriteLine("Your appointed customers are:");
                string[] dname = { "Customer Name: ", "Service: ", "Price: ", "Day: ", "Time: ", "Status: " };
                int[] val = { 2, 3, 4, 7, 8, 9 };
                showlist("workers/appointments/" + wid.ToString() + ".txt", dname, val, "Approved", 9);
            }
            else 
            {
                Console.WriteLine("You have not assigned any Appointments for now");
            }
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            WorkerOptions(wid);


        }

        static void billCustomers(int wid)
        {
            Console.Clear();
            bool chk = false;
            if (File.Exists("workers/appointments/" + wid.ToString() + ".txt"))
            {

                using (StreamReader sr = new StreamReader("workers/appointments/" + wid.ToString() + ".txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[9] == "Gone")
                        {
                            chk = true;
                        }
                    }
                }
            }
            if (chk == true)
            {
                Console.WriteLine("Your appointed customers are:");
                string[] dname = { "Appointment ID: ","Customer Name: ", "Service: ", "Price: ", "Day: ", "Time: ", "Status: " };
                int[] val = { 0,2, 3, 4, 7, 8, 9 };
                showlist("workers/appointments/" + wid.ToString() + ".txt", dname, val, "Gone", 9);
            id:Console.Write("Enter appointment ID: ");
                int id;
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only Integer");
                    goto id;
                }
                updatesomething("workers/appointments/" + wid.ToString() + ".txt", id.ToString(), 0, 9, "Payment Pending");
                updatesomething("appointments.txt", id.ToString(), 0,11, "Payment Pending");
                string cid ="";
                findsomething("appointments.txt",0,id.ToString(),ref cid,1);
                updatesomething("customers/appointments/" + cid + ".txt", id.ToString(), 0, 11, "Payment Pending");
                string price = "";
                findsomething("workers/appointments/" + wid.ToString() + ".txt",0,id.ToString(),ref price,4);
                Console.WriteLine("Payment Successfull of "+price+"Rs.");
            }
            else
            {
                Console.WriteLine("You don't have any Payment Pending for now");
            }

        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            WorkerOptions(wid);

        }

        // Customer Position
        static void Customersignuporlogin()
        {
            Console.Clear();

            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                          Customer Sign Or Login");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.WriteLine("What do you want to do\n\tPress 1 to Sign Up\n\tPress 2 to Login:\n\tPress 3 to Change Position");
        st: Console.Write("Enter Here: ");
            int b;
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException) 
            {
                Console.WriteLine("Enter only Integer");
                goto st;
            }
            if (b == 1)
            {
                Customersignup();
            }
            else if (b == 2)
            {
                Customerlogin();
            }
            else if (b == 3)
            {
                typeofInput();
            }
            else
            {
                Console.Write("Enter a Valid Option:");
                goto st;
            }


        }

        static void Customersignup()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                            Customer Signup");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

        email: Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            bool ch = false;
            foreach (char c in email)
            {
                if (c == '@')
                {
                    ch = true;
                    break;
                }
            }
            if (ch == false)
            {
                Console.WriteLine("Enter a valid Email Address!");
                goto email;
            }

        cn: Console.Write("Enter Contact Number: ");
            long cont;
            try
            {
                cont = Convert.ToInt64(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto cn;
            }
            if (cont.ToString().Length != 10)
            {
                Console.WriteLine("Contact Number should be of 11 digits");
                goto cn;
            }

        pass: Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (pass.Length < 8)
            {
                Console.WriteLine("Password must be Greater than or Equal to 8 Characters");
                goto pass;
            }
        conpass: Console.Write("Confirm Password: ");
            string conpass = Console.ReadLine();

            if (conpass != pass)
            {
                Console.WriteLine("Password and Confirm Password should be same");
                goto conpass;
            }

        id: Console.Write("Enter Customer ID: ");
            int cid;
            try
            {
                cid = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
            if (cid.ToString().Length != 4)
            {
                Console.WriteLine("ID should be of 4 Digits");
                goto id;
            }

            int error = 0;
            signup(name, cont, email, pass, cid, "customerdetail.txt", ref error);
            if (error == 1)
            {
                Console.WriteLine("This id Already Exists, Please Enter a Different ID");
                goto id;
            }
            else
            {
                Console.WriteLine("SignUp Successfull");
            abc:Console.WriteLine("Press any key to Continue");
                char c;
                try
                {
                    c = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a Single Character");
                    goto abc;
                }
                customeroptions(cid);
            }
        }

        static void Customerlogin()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                              Customer Login");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
        uid: Console.Write("Enter Customer ID: ");
        int cid;
        try
        {
            cid = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException) 
        {
            Console.WriteLine("Enter only Integer");
            goto uid;
        }
        pas: Console.Write("Enter Password: ");
            string pass = Console.ReadLine();
            int error = 0;
            login(cid, pass, ref error, "customerdetail.txt");
            if (error == 1)
            {
                Console.WriteLine("Invalid User ID");
                goto uid;
            }
            else if (error == 2)
            {
                Console.WriteLine("Invalid Password, Enter Again");
                goto pas;
            }
            else
            {
                customeroptions(cid);
            }
        }

        static void customeroptions(int cid)
        {
            bool chk = false;
            checkingcustomerPayment(cid, ref chk);
            if (chk == true)
            {
                customerPayment(cid);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Press the Required options to access them"
                    + "\n\tPress a to Appoint a Service"
                    + "\n\tPress g to Go to the Services"
                    + "\n\tPress p to get Previously reviewed Customers"
                    + "\n\tPress o to check your Old Appointments"
                    + "\n\tPress l to Log out");
                Console.Write("Enter Here: ");
            c: char c;
            try
            {
                c = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a Single Character");
                goto c;
            }
                if (c == 'a' || c == 'A')
                {
                    makeappointment(cid);
                }
                else if (c == 'g' || c == 'G')
                {
                    gorejservice(cid);
                }
                else if (c == 'p' || c == 'P')
                {
                    prevrated(cid);
                }
                else if (c == 'o' || c == 'O')
                {
                    oldappoint(cid);
                }
                else if (c == 'l' || c == 'L')
                {
                    typeofInput();
                }
                else
                {
                    Console.Write("Enter a valid Key, Again: ");
                    goto c;
                }
            }

        }
        static void checkingcustomerPayment(int cid, ref bool chk) 
        {
            if (File.Exists("customers/appointments/" + cid.ToString() + ".txt"))
            {
                using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[11] == "Payment Pending")
                        {
                            chk = true;
                        }
                    }
                }
            }
        }
        static void customerPayment(int cid) 
        {

            Console.Clear();
            Console.WriteLine("\t\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t\t       Wait, You Have Some Pending Dues Please Clear Them First");
            Console.WriteLine("\t\t\t\t************************************************************************");
            Console.WriteLine();
            string[] dt = { "Appointment ID: ", "", "Worker ID: ", "", "", "Service: ", "Price: ", "Time: ", "Day: ", "", "", "Status: " };
            using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[11] == "Payment Pending")
                        {
                            if (i == 0 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 11)
                            {
                                Console.WriteLine(dt[i] + data[i]);
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        id: Console.WriteLine("Enter Appointment ID : ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
            bool chhk = false;
            using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    if (data[0] == id.ToString())
                    {
                        chhk = true;
                    }
                }
            }
            if (chhk == true)
            {
                Console.WriteLine("Press 1 to pay\nPress 2 to Go back");
                Console.Write("Enter here: ");
            c: char c;
                try
                {
                    c = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a Single Character");
                    goto c;
                }
                string wid = "";
                findsomething("appointments.txt", 0, id.ToString(), ref wid, 2);
                if (c == '1')
                {
                    Console.WriteLine("Press 1 to Give Review\nPress 2 to Continue without giving Review");
                    Console.Write("Enter here: ");
                a: char a;
                    try
                    {
                        a = Convert.ToChar(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a Single Character");
                        goto a;
                    }
                    if (a == '1')
                    {
                        Console.Write("Enter Rating: ");
                    rat: double review = Convert.ToDouble(Console.ReadLine());
                        if (review > 5 && review < 1)
                        {
                            Console.Write("Enter Review Between 1 to 5: ");
                            goto rat;
                        }
                        Console.Write("Enter Review message :");
                        string revmes = Console.ReadLine();
                        updatesomething("customers/appointments/" + cid.ToString() + ".txt", id.ToString(), 0, 9, review.ToString());
                        updatesomething("appointments.txt", id.ToString(), 0, 9, review.ToString());
                        updatesomething("workers/appointments/" + wid.ToString() + ".txt", id.ToString(), 0, 5, review.ToString());
                        double rating = 0, avg;
                        int count = 0;
                        using (StreamReader sr = new StreamReader("workers/appointments/" + wid.ToString() + ".txt"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null) 
                            {
                                string[] data = line.Split('|');
                                if (data[5] != " ") 
                                {
                                    rating += Convert.ToDouble(data[5]);
                                    count++;
                                } 
                            }
                        }
                        avg = rating / count;
                        avg = (rating + review) / 2;
                        updatesomething("workerdetail.txt", wid.ToString(), 0, 7, avg.ToString());
                        updatesomething("customers/appointments/" + cid.ToString() + ".txt", id.ToString(), 0, 10, revmes);
                        updatesomething("appointments.txt", id.ToString(), 0, 10, revmes);
                        updatesomething("workers/appointments/" + wid.ToString() + ".txt", id.ToString(), 0, 6, revmes);
                    }
                    else if (a == '2')
                    {

                    }
                    else
                    {
                        Console.Write("Enter a Valid Character again: ");
                        goto a;
                    }
                    updatesomething("customers/appointments/" + cid.ToString() + ".txt", id.ToString(), 0, 11, "Completed");
                    updatesomething("appointments.txt", id.ToString(), 0, 11, "Completed");
                    updatesomething("workers/appointments/" + wid.ToString() + ".txt", id.ToString(), 0, 9, "Completed");
                    Console.WriteLine("Payment Successful");
                ca: Console.WriteLine("Press any key to continue");
                    try
                    {
                        Console.ReadKey();
                    }
                    catch (FormatException)
                    {
                        goto ca;
                    }
                    customeroptions(cid);
                }
                else if (c == '2')
                {
                    typeofInput();
                }
                else
                {
                    Console.WriteLine("Enter a valid key");
                    goto c;
                }

            }
            else
            {
                Console.WriteLine("This id doesn't Exists, Enter Again: ");
                goto id;
            }
        }

        static void makeappointment(int cid)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                            Appointment Making");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            string name = "";

            accessname(cid, "customerdetail.txt", ref name);

            Console.WriteLine("Enter your Gender\n\tPress m for Male\n\tPress f for Female");
            Console.Write("Enter Here: ");
            abc:char g;
            try
            {
                g = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a Single Character");
                goto abc;
            }
            showservices(g, cid);
        id: Console.Write("Enter Service ID to Book Now: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only Integer");
                goto id;
            }
             

            bool chk = false;
            using (StreamReader sr = new StreamReader("services.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    if (id.ToString() == data[0])
                    {
                        appointmentmaking(cid, name, data[1], Convert.ToInt32(data[2]), "Pending");
                        chk = true;
                    }
                }
                if (chk == false)
                {
                    Console.WriteLine("Service ID is incorrect");
                    goto id;
                }
                else
                {
                    Console.WriteLine("Appointment R|equest Sent Successfully!");
                    Console.WriteLine("You will get a suitable time slot after the admin approve this Request");
                ca: Console.WriteLine("Press any key to continue");
                    try
                    {
                        Console.ReadKey();
                    }
                    catch (FormatException)
                    {
                        goto ca;
                    };
                    customeroptions(cid);
                }
            }
        }
        static void showservices(char g, int cid)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Serivces For You");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            if (g == 'm' || g == 'M' || g == 'f' || g == 'F')
            {
                using (StreamReader sr = new StreamReader("services.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] dataname = { "Service ID: ", "Service Name: ", "Service Price: ", "Service Gender: " };
                        string[] data = line.Split('|');
                        if (g == 'm' || g == 'M')
                        {
                            if (data[3] == "1" || data[3] == "3")
                            {
                                for (int i = 0; i < data.Length; i++)
                                {
                                    if (i == 3)
                                    {
                                        Console.WriteLine(dataname[i] + "Male");
                                    }
                                    else
                                    {
                                        Console.WriteLine(dataname[i] + data[i]);
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        else if (g == 'f' || g == 'F')
                        {
                            if (data[3] == "2" || data[3] == "3")
                            {
                                for (int i = 0; i < data.Length; i++)
                                {
                                    if (i == 3)
                                    {
                                        Console.WriteLine(dataname[i] + "Female");
                                    }
                                    else
                                    {
                                        Console.WriteLine(dataname[i] + data[i]);
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Key Again");
            ca: Console.WriteLine("Press any key to continue");
                try
                {
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    goto ca;
                } 
                makeappointment(cid);
            }
        }

        static void gorejservice(int cid)
        {
            Console.Clear();
            Console.WriteLine("Let's go to Your Approved Appointment!");
            Console.WriteLine("Your Appointments: ");
            if (File.Exists("customers/appointments/" + cid.ToString() + ".txt"))
            {
                string[] dataname = { "Appointment ID: ", "Customer ID: ", "Worker ID: ", "Customer Name: ", "Worker Name: ", "Service: ", "Price: ", "Time: ", "Day: ", "Review: ", "Review Message: ", "Status: " };
                bool app = false;
                using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
                {//appid,cid,wid,cname,wname,service,price,review,revmes,time,day,status
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[11] == "Approved")
                        {
                            app = true;
                            for (int i = 0; i < data.Length; i++)
                            {
                                if (i != 1 && i != 2 && i != 9 && i != 10)
                                {
                                    Console.WriteLine(dataname[i] + data[i]);
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                    }
                }
                if (app == true)
                {
                id: Console.WriteLine("Enter Appointment ID to go to the Service : ");
                    int aid;
                    try
                    {
                        aid = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only Integer");
                        goto id;
                    }
             
                    bool chk = false;
                    using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (aid.ToString() == data[0])
                            {
                                chk = true;
                            }
                        }
                    }
                    if (chk == false)
                    {
                        Console.WriteLine("Please Enter an Appropriate ID: ");
                        goto id;
                    }
                    else
                    {
                        Console.WriteLine("Press any option to Continue:\n\tPress 1 to Go to the Appointment\n\tPress 2 to Cancel this Appointment(Will Cost You Rs. 100 Fine)");
                        Console.Write("Enter Here: ");
                    ch: char c;
                    try
                    {
                        c = Convert.ToChar(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a Single Character");
                        goto ch;
                    }
                        if (c == '1')
                        {
                            goservice(cid, aid);
                        }
                        else if (c == '2')
                        {
                            cancelservice(cid, aid);
                        }
                        else
                        {
                            Console.WriteLine("Press a valid key: ");
                            goto ch;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("None of your Appointments are Approved, Please come again Later");
                c: Console.WriteLine("Press any key to continue");
                    try
                    {
                        Console.ReadKey();
                    }
                    catch (FormatException)
                    {
                        goto c;
                    } 
                    customeroptions(cid);

                }
            }
            else
            {
                Console.WriteLine("You Don't Have any Appointments for Now");
                Console.WriteLine("\n\tPress b to book appointment\n\tPress c to Cancel");
                Console.Write("Enter Here: ");
            c: char c;
            try
            {
                c = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a Single Character");
                goto c;
            }
            if (c == 'b' || c == 'B')
                {
                    makeappointment(cid);
                }
            else if (c == 'c' || c == 'C')
                {
                    customeroptions(cid);
                }
                else
                {
                    Console.WriteLine("Press a valid key : ");
                    goto c;
                }
            }
        }

        static void goservice(int cid, int aid)
        {
            Console.Clear();
            Console.WriteLine("Completing the Service, Wait a While");
            updatesomething("appointments.txt", aid.ToString(), 0, 11, "Gone");
            updatesomething(("customers/appointments/" + cid.ToString() + ".txt"), aid.ToString(), 0, 11, "Gone");
            string wid = "";
            findsomething("appointments.txt", 0, aid.ToString(), ref wid, 2);
            updatesomething(("workers/appointments/" + wid + ".txt"), aid.ToString(), 0, 9, "Gone");

            Console.WriteLine("Appointment Completed Successfully, The Worker will charge your bill After a While Till then Press any key to continue");
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            customeroptions(cid);

        }

        static void cancelservice(int cid, int aid)
        {
            Console.Clear();
            Console.WriteLine("Cancelling Service, Wait a While");
            updatesomething("appointments.txt", aid.ToString(), 0, 11, "Cancelled");
            updatesomething("appointments.txt", aid.ToString(), 0, 6, "100");
            updatesomething(("customers/appointments/" + cid.ToString() + ".txt"), aid.ToString(), 0, 11, "Cancelled");
            updatesomething(("customers/appointments/" + cid.ToString() + ".txt"), aid.ToString(), 0, 6, "100");
            string wid = "";
            findsomething("appointments.txt", 0, aid.ToString(), ref wid, 2);
            updatesomething(("workers/appointments/" + wid + ".txt"), aid.ToString(), 0, 11, "Cancelled");
            updatesomething(("workers/appointments/" + wid + ".txt"), aid.ToString(), 0, 6, "100");

            Console.WriteLine("Appointment Cancelled Successfully, You have been charged with a Fine of 100Rs.");
           c: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException) 
            {
                goto c;
            }
            customeroptions(cid);
        }

        static void prevrated(int cid)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                             Previously Rated");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            string[] dataname = { "Worker Name: ", "Service: ", "Review: ", "Review Meseage: " };
            int[] dtspc = { 4, 5, 9, 10 };//appid,cid,wid,cname,wname,service,price,review,revmes,time,day,status
            bool chk = false;
            if (File.Exists("customers/appointments/" + cid.ToString() + ".txt"))
            {
                using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[9] != " ")
                        {
                            chk = true;
                        }
                    }

                }
            }
            if (chk == false)
            {
                Console.WriteLine("You don't have any review to show");
            }
            else
            {
                using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[9] != " " || data[10] != " ")
                        {
                            for (int i = 0; i < dtspc.Length; i++)
                            {

                                Console.WriteLine(dataname[i] + data[dtspc[i]]);
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }

                }
            }
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            customeroptions(cid);
        }

        static void oldappoint(int cid)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine("\t\t\t                              My Appointments");
            Console.WriteLine("\t\t\t************************************************************************");
            Console.WriteLine();
            bool chk = false;
            Console.WriteLine("Your Total Appointments Are: ");
            string[] names = {"Worker Name: ","Service: ","Price: ","Time: ","Day: ","Review: ","Review Message: ","Status: " };
            int[] spc ={4,5,6,7,8,9,10,11};
            if (File.Exists("customers/appointments/" + cid.ToString() + ".txt"))
            {
                using (StreamReader sr = new StreamReader("customers/appointments/" + cid.ToString() + ".txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data != null)
                        {
                            chk = true;
                        }

                    }
                }
            }
            if (chk == true)
            {
                showlist("customers/appointments/" + cid.ToString() + ".txt", names, spc);
            }
            else 
            {
                Console.WriteLine("You don't have any Appointments for Now!");
            }
        ca: Console.WriteLine("Press any key to continue");
            try
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                goto ca;
            } 
            customeroptions(cid);
        }

        // All Positions
        static void login(int uid, string pass, ref int ecode, string file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                bool chkuid = false, chkpass = false;

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    int id = Convert.ToInt32(data[0]);
                    string ps = data[1];
                    if (id == uid)
                    {
                        chkuid = true;
                        if (pass == ps)
                        {
                            chkpass = true;
                            break;
                        }
                    }
                }
                if (chkpass == false)
                {
                    ecode = 2;
                    if (chkuid == false)
                    {
                        ecode = 1;
                    }
                }
            }
        }

        static void signup(string name, long contact, string email, string pass, int id, string file, ref int ecode, long cnic = 0, int sal = 0)
        {
            bool check = false;
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        int oldid = Convert.ToInt32(data[0]);
                        if (oldid == id)
                        {
                            check = true;
                        }
                    }

                }


                if (check == true)
                {
                    ecode = 1;
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(file, append: true))
                    {
                        if (cnic != 0)
                        {
                            sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}|0", id, pass, name, email, contact, cnic, sal);
                        }
                        else
                        {
                            sw.WriteLine("{0}|{1}|{2}|{3}|{4}", id, pass, name, email, contact);
                        }
                    }
                }
            }
            else 
            {
                File.Create(file).Dispose();
             
                    using (StreamWriter sw = new StreamWriter(file, append: true))
                    {
                        if (cnic != 0)
                        {
                            sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}|0", id, pass, name, email, contact, cnic, sal);
                        }
                        else
                        {
                            sw.WriteLine("{0}|{1}|{2}|{3}|{4}", id, pass, name, email, contact);
                        
                    }
                }
            }

        }
   
        static void appointmentmaking(int cid, string cname, string service, int price, string status)
        {
            Random r = new Random();
        again: int appID = r.Next(1000, 9999);
            if (File.Exists("appointments.txt"))
            {
                using (StreamReader sr = new StreamReader("appointments.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[0] == appID.ToString())
                        {
                            goto again;
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("customers/appointments/" + cid.ToString() + ".txt", append: true))
            {
                sw.WriteLine("{0}|{1}| |{2}| |{3}|{4}| | | | |{5}", appID, cid, cname, service, price, status); //appid,cid,wid,cname,wname,service,price,review,revmes,time,day,status
            }
            using (StreamWriter sw = new StreamWriter("appointments.txt", append: true))
            {
                sw.WriteLine("{0}|{1}| |{2}| |{3}|{4}| | | | |{5}", appID, cid, cname, service, price, status); //appid,cid,wid,cname,wname,service,price,review,time,day,status
            }

        }

        static void accessname(int cid, string file, ref string name)
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (cid.ToString() == data[0])
                        {
                            name = data[2];
                        }
                    }
                }
            }
        }

        static void updatesomething(string file, string matchcase, int matchcaseindex, int dataindex, string dataval)
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    using (StreamWriter sw = new StreamWriter("temp.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data[matchcaseindex] == matchcase)
                            {
                                data[dataindex] = dataval;
                                for (int i = 0; i < data.Length; i++)
                                {
                                    if (i != data.Length - 1)
                                    {
                                        sw.Write(data[i] + "|");
                                    }
                                    else
                                    {
                                        sw.Write(data[i]);
                                    }
                                }
                                sw.WriteLine();

                            }
                            else
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                File.Delete(file);
                File.Move("temp.txt", file);
            }
        }

        static void findsomething(string file, int mcaseindex, string mcase, ref string value, int valueindex)
        {
            if(File.Exists(file)){
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (data[mcaseindex] == mcase)
                        {
                            value = data[valueindex];
                        }
                    }
                }
            }
        }

        static void deletesomething(string file, ref bool chk, string mcase, int mcaseindex)
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    using (StreamWriter sw = new StreamWriter("temp.txt"))
                    {

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data[mcaseindex] == mcase)
                            {
                                chk = true;
                            }
                            else
                            {
                                sw.WriteLine(line);
                            }
                        }

                    }
                }
                File.Delete(file);
                File.Move("temp.txt", file);
            }
        }

        static void showlist(string file, string[] dataname, int[] dtspc = null, string chkvalue= null, int index = 0)
        {
            if(File.Exists(file)){
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        if (chkvalue == null)
                        {
                            if (dtspc == null)
                            {
                                for (int i = 0; i < data.Length; i++)
                                {
                                    Console.WriteLine(dataname[i] + data[i]);

                                }
                            }
                            else
                            {
                                for (int i = 0; i < dtspc.Length; i++)
                                {
                                    Console.WriteLine(dataname[i] + data[dtspc[i]]);
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            if (chkvalue == data[index])
                            {
                                if (dtspc == null)
                                {
                                    for (int i = 0; i < data.Length; i++)
                                    {
                                        Console.WriteLine(dataname[i] + data[i]);

                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < dtspc.Length; i++)
                                    {
                                        Console.WriteLine(dataname[i] + data[dtspc[i]]);
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
