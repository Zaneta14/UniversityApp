using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBproekt.Models
{
    public class NullableIntModelBinder 
        //: IModelBinder
    {
        /*public bool BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(int?))
            {
                return false;
            }

            ValueProviderResult val = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (val == null)
            {
                return false;
            }

            string rawvalue = val.FirstValue as string;

            // Not supplied : /test/5
            if (rawvalue == null)
            {
                bindingContext.Model = null;
                return true;
            }

            // Provided but with no value : /test/5?something=
            if (rawvalue == string.Empty)
            {
                bindingContext.Model = null;
                return true;
            }

            // Provided with a value : /test/5?something=1
            int result;
            if (int.TryParse(rawvalue, out result))
            {
                bindingContext.Model = result;
                return true;
            }

            bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Cannot convert value to int");
            return false;
        }

        public Task BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }

       


        /* HttpRequestBase request = ControllerContext.HttpContext.Request;

         List<string> nameValues = new List<string>();

         int id = Convert.ToInt32(request.Form.Get("Id"));
         nameValues.Add(request.Form.Get("FirstName"));
             nameValues.Add(request.Form.Get("MiddleName"));
             nameValues.Add(request.Form.Get("LastName"));
             string address = request.Form.Get("Address");
         string department = request.Form.Get("Department");
         DateTime joinDate = Convert.ToDateTime(request.Form.Get("JoinDate"));

             return new EmployeeViewModel()
         {
             Id = id,
                 FullName = string.Join(" ", nameValues),
                 Address = address,
                 Department = department,
                 JoinDate = joinDate
             };*/
    }
}