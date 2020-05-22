using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ComboBox_Dropdown
{
    /// <summary>
    /// ViewModel class
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Collection field
        /// </summary>
        private ObservableCollection<Employee> employeeCollection;
        
        /// <summary>
        /// Employee names collection
        /// </summary>
        public ObservableCollection<Employee> EmployeeCollection
        {
            get { return employeeCollection; }
            set { employeeCollection = value; }
        }
        public EmployeeViewModel()
        {
            employeeCollection = new ObservableCollection<Employee>();
            employeeCollection.Add(new Employee() { Name = "Frank" });
            employeeCollection.Add(new Employee() { Name = "James" });
            employeeCollection.Add(new Employee() { Name = "Steve" });
            employeeCollection.Add(new Employee() { Name = "Lucas" });
            employeeCollection.Add(new Employee() { Name = "Mark" });
            employeeCollection.Add(new Employee() { Name = "Michael" });
            employeeCollection.Add(new Employee() { Name = "Aldrin" });
            employeeCollection.Add(new Employee() { Name = "Jack" });
            employeeCollection.Add(new Employee() { Name = "Howard" });
        }
    }
}
