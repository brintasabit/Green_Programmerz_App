using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.DatabaseContext.DatabaseContext;

namespace GreenProgrammerz.Repository.Repository
{
   
    public class CategoryRepository
    {
        ProjectDbContext dbContext=new ProjectDbContext();
        public bool SaveInfo(Category _category)
        {
            ////string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            //string commandString = @"insert into Category values('"+_category.Code+"','"+_category.Name+"')";
            //SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //sqlConnection.Open();
            //int isSaved = sqlCommand.ExecuteNonQuery();
            //if (isSaved>0)
            //{
            //    return true;
            //}
            //sqlConnection.Close();
            dbContext.Categories.Add(_category);
            
            return dbContext.SaveChanges()>0;
        }

    }
}
