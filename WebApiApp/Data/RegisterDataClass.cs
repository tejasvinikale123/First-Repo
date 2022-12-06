using WebApiApp.Models;

namespace WebApiApp.Data
{
    public class RegisterDataClass
    {
       static List<Register> registerList = new List<Register>();

        public static List<Register> SelectAll()
        {
            return registerList.ToList();
        }
        public static Register Select(int id)
        {
            
            return registerList.Where(a=>a.Id == id).FirstOrDefault();
        }
        public static Register Add(Register model)
       {
            var lastid = registerList.OrderByDescending(a => a.Id).Select(s=>s.Id).FirstOrDefault();
            if(lastid != 0)
            {
                model.Id = lastid+1;
            }
            else
            {
                model.Id = 1;
            }
            registerList.Add(model);
            return model;

       }

       public static Register Update(Register model)
        {
            var updateModel = registerList.Where(a => a.Id == model.Id).FirstOrDefault();
            Delete(updateModel.Id);


            model.Id=updateModel.Id;
            registerList.Add(model);

            return model;

        }
        public static Boolean Delete(int id)
        {
            var result = registerList.Where(a => a.Id == id).FirstOrDefault();

            return registerList.Remove(result);

        }

    }
}
