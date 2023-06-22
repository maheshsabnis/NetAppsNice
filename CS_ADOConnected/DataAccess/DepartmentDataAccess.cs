using CS_ADOConnected.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS_ADOConnected.DataAccess
{
    internal class DepartmentDataAccess : IDataAccess<Department, int>, IDisposable
    {
        SqlConnection Conn;
        SqlCommand Cmd;

        public DepartmentDataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=Company;Integrated Security=SSPI");   
        }

        public void Dispose()
        {
            Conn.Dispose();
        }

        async Task<Department> IDataAccess<Department, int>.CreateAsync(Department entity)
        {
            try
            {
                Conn.Open();
                Cmd = Conn.CreateCommand();
                // Parameter Query
                Cmd.CommandText = "Insert into Department Values (@DeptNo,@DeptName,@Capacity,@Location)";
                // Set the Parameters 
                Cmd.Parameters.AddWithValue("@DeptNo", entity.DeptNo);
                Cmd.Parameters.AddWithValue("@DeptName", entity.DeptName);
                Cmd.Parameters.AddWithValue("@Location", entity.Location);
                Cmd.Parameters.AddWithValue("@Capacity", entity.Capacity);

                int res = await Cmd.ExecuteNonQueryAsync();
                Conn.Close();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        async Task<bool> IDataAccess<Department, int>.DeleteAsync(int id)
        {
            try
            {
                Conn.Open();
                Cmd = Conn.CreateCommand();
                // Parameter Query
                Cmd.CommandText = "Delete Department where DeptNo=@DeptNo";
                // Set the Parameters 
                Cmd.Parameters.AddWithValue("@DeptNo", id);

                int res = await Cmd.ExecuteNonQueryAsync();
                Conn.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        async Task<IEnumerable<Department>> IDataAccess<Department, int>.GetAsync()
        {
            List<Department> departments = new List<Department>();
            try
            {
                // 1. Open the Connection
                Conn.Open();
                // 2. Create Cmmand Object for the Opend Connection
                Cmd = Conn.CreateCommand();
                // 3. Define the Command Type for the Command Object
                Cmd.CommandType = System.Data.CommandType.Text;
                // 4. Passs the SQL Statement
                Cmd.CommandText = "Select * from Department";
                // 5. Execute the Command
                SqlDataReader reader = await Cmd.ExecuteReaderAsync();
                // 6. Iterate over Reader to Read all data
                while (reader.Read())
                {
                    departments.Add(new Department() 
                    { 
                       // Read each columns from the SqlDataREader and assign it to the
                       // Department Object's property

                        DeptNo = Convert.ToInt32(reader["DeptNo"]),
                        DeptName = reader["DeptName"].ToString(),
                        Location = reader["Location"].ToString(),
                        Capacity = Convert.ToInt32(reader["Capacity"])
                    });
                }
                reader.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return departments;
        }

        async Task<Department> IDataAccess<Department, int>.GetAsync(int id)
        {
           Department department = new Department();
            try
            {
                // 1. Open the Connection
                Conn.Open();
                // 2. Create Cmmand Object for the Opend Connection
                Cmd = Conn.CreateCommand();
                // 3. Define the Command Type for the Command Object
                Cmd.CommandType = System.Data.CommandType.Text;
                // 4. Passs the SQL Statement
                Cmd.CommandText = "Select * from Department where DeptNo=@DeptNo";
                Cmd.Parameters.AddWithValue("@DeptNo", id);

                // 5. Execute the Command
                SqlDataReader reader = await Cmd.ExecuteReaderAsync();
                // 6. Iterate over Reader to Read all data
                while (reader.Read())
                {
                    department.DeptNo = Convert.ToInt32(reader["DeptNo"]);
                    department.DeptName = reader["DeptName"].ToString();
                    department.Location = reader["Location"].ToString();
                    department.Capacity = Convert.ToInt32(reader["Capacity"]);
                }
                reader.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return department;
        }

        async Task<Department> IDataAccess<Department, int>.UpdateAsync(int id, Department entity)
        {
            try
            {
                Conn.Open();
                Cmd = Conn.CreateCommand();
                // Parameter Query
                Cmd.CommandText = "Update Department Set DeptName=@DeptName,Capacity=@Capacity,Location=@Location  where DeptNo=@DeptNo";
                // Set the Parameters 
                Cmd.Parameters.AddWithValue("@DeptNo", entity.DeptNo);
                Cmd.Parameters.AddWithValue("@DeptName", entity.DeptName);
                Cmd.Parameters.AddWithValue("@Location", entity.Location);
                Cmd.Parameters.AddWithValue("@Capacity", entity.Capacity);

                int res = await Cmd.ExecuteNonQueryAsync();
                Conn.Close();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
