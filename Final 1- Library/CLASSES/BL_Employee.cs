using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Final_1__Library.CLASSES
{
    internal class BL_Employee
    {

        public DataTable Take_Employee()
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps =
            from p in qltvEntity.EMPLOYEES
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Emloyee");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Position");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Working_Time");
            dt.Columns.Add("Extra");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Employee, p.Name, p.Gender, p.CCCD, p.Phone, p.Address, p.Position, p.Salary, p.Working_time, p.Extra);
            }

            return dt;
        }
        public bool Add_Employee(int id, string name, string gender, int cccd, int phone, string address, string position, int workingtime, int extra)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            int salary = 0;
            EMPLOYEE employee = new EMPLOYEE();
            if (position == "Cashier")
            {
                Cashier cashier = new Cashier();
                salary = (int)cashier.Cal_Salary(workingtime, extra);
            }
            if (position == "Guard")
            {
                Guard guard = new Guard();
                salary = (int)guard.Cal_Salary(workingtime, extra);
            }
            if (position == "Accountant")
            {
                Accountant accountant = new Accountant();
                salary = (int)accountant.Cal_Salary(workingtime, extra);
            }
            employee.ID_Employee = id;
            employee.Name = name;
            employee.Gender = gender;
            employee.CCCD = cccd;
            employee.Phone = phone;
            employee.Address = address;
            employee.Position = position;
            employee.Salary = salary;
            employee.Working_time = workingtime;
            employee.Extra = extra;
            qltvEntity.EMPLOYEES.Add(employee);
            qltvEntity.SaveChanges();

            return true;

        }

        public bool Edit_Employee(int id, string name, string gender, int cccd, int phone, string address, string position, int workingtime, int extra)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.EMPLOYEES
                           where p.ID_Employee == id
                           select p).SingleOrDefault();
            int salary = 0;
            EMPLOYEE employee = new EMPLOYEE();
            if (position == "Cashier")
            {
                Cashier cashier = new Cashier();
                salary = (int)cashier.Cal_Salary(workingtime, extra);
            }
            if (position == "Guard")
            {
                Guard guard = new Guard();
                salary = (int)guard.Cal_Salary(workingtime, extra);
            }
            if (position == "Accountant")
            {
                Accountant accountant = new Accountant();
                salary = (int)accountant.Cal_Salary(workingtime, extra);
            }
            if (tpQuery != null)
            {
                tpQuery.Name = name;
                tpQuery.Gender = gender;
                tpQuery.CCCD = cccd;
                tpQuery.Phone = phone;
                tpQuery.Address = address;
                tpQuery.Position = position;
                tpQuery.Salary = salary;
                tpQuery.Working_time = workingtime;
                tpQuery.Extra = extra;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public DataTable GetObjectByID(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.EMPLOYEES
                       where p.ID_Employee == id
                       select p) ;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Emloyee");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Position");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Working_Time");
            dt.Columns.Add("Extra");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Employee, p.Name, p.Gender, p.CCCD, p.Phone, p.Address, p.Position, p.Salary, p.Working_time, p.Extra);
            }
            return dt;
        }
        public DataTable GetObjectByName(string name)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.EMPLOYEES
                       where p.Name == name
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Emloyee");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Position");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Working_Time");
            dt.Columns.Add("Extra");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Employee, p.Name, p.Gender, p.CCCD, p.Phone, p.Address, p.Position, p.Salary, p.Working_time, p.Extra);
            }
            return dt;
        }
        public DataTable GetObjectByCCCD(int cccd)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.EMPLOYEES
                       where p.CCCD == cccd
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Emloyee");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Position");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Working_Time");
            dt.Columns.Add("Extra");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Employee, p.Name, p.Gender, p.CCCD, p.Phone, p.Address, p.Position, p.Salary, p.Working_time, p.Extra);
            }
            return dt;
        }
        public DataTable GetObjectByPosition(string id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.EMPLOYEES
                       where p.Position == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Emloyee");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Position");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Working_Time");
            dt.Columns.Add("Extra");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Employee, p.Name, p.Gender, p.CCCD, p.Phone, p.Address, p.Position, p.Salary, p.Working_time, p.Extra);
            }
            return dt;
        }
        public bool Delete_Employee(int id, string name)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            EMPLOYEE employee = new EMPLOYEE();
            employee.ID_Employee = id;
            employee.Name = name;
            qltvEntity.EMPLOYEES.Attach(employee);
            qltvEntity.EMPLOYEES.Remove(employee);
            qltvEntity.SaveChanges();

            return true;
        }
    }
}
