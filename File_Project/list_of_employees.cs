using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Project
{
    class list_of_employees
    {
        public List<employee> emplist = new List<employee>();

       public List<int> not_null(int col)
        {
            List<int> err = new List<int>();



            return err;
        }
        public void def(string col,string val)
        {
            if (col=="name")
            {
                for (int i = 0; i < emplist.Count(); i++)
                {
                    if(emplist[i].name==null)
                    {
                        emplist[i].name = val;
                    }
                }
            }
            else if(col=="id")
            {
                for (int i = 0; i < emplist.Count(); i++)
                {
                    if (emplist[i].id == null)
                    {
                        emplist[i].id = val;
                    }
                }
            }
            else if (col == "salary")
            {
                for (int i = 0; i < emplist.Count(); i++)
                {
                    if (emplist[i].salary == null)
                    {
                        emplist[i].salary = val;
                    }
                }
            }
            else if (col == "age")
            {
                for (int i = 0; i < emplist.Count(); i++)
                {
                    if (emplist[i].age == null)
                    {
                        emplist[i].age = val;
                    }
                }
            }
            else if (col == "gender")
            {
                for (int i = 0; i < emplist.Count(); i++)
                {
                    if (emplist[i].gender == null)
                    {
                        emplist[i].gender = val;
                    }
                }
            }
            else if (col == "depart")
            {
                for (int i = 0; i < emplist.Count(); i++)
                {
                    if (emplist[i].depart == null)
                    {
                        emplist[i].depart = val;
                    }
                }
            }
            
        }

        public List<int> unique(string [] arr)
        {
            List<int> err = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "name")
                {
                    for (int x = 0; x < emplist.Count()-1; x++)
                    {
                        for (int d = x+1; d < emplist.Count(); d++)
                        {
                            if (emplist[x].name==emplist[d].name)
                            {
                                err.Add(x);
                                emplist[x].id = "-1";
                            }
                        }
                    }
                }

                else if (arr[i] == "id")
                {
                    for (int x = 0; x < emplist.Count() - 1; x++)
                    {
                        for (int d = x + 1; d < emplist.Count(); d++)
                        {
                            if (emplist[x].id == emplist[d].id)
                            {
                                err.Add(x);
                                emplist[x].id = "-1";
                            }
                        }
                    }
                }
            }


            return err;
        }
        public List<int> check(string col,string val)
        {
            //employee emp= new employee();
            List<int> err = new List<int>();
            if(col=="salary")
            {
                for (int i = 0; i < emplist.Count(); i++)
                   {
                   if (int.Parse(emplist[i].salary)<int.Parse(val))
                     {
                         emplist[i].id = "-1";
                          err.Add(i);            
                     }
                   }
            }
            if(col=="age")
            {
                for (int i = 0; i < emplist.Count(); i++)
                   {
                     if (int.Parse(emplist[i].age) < int.Parse(val))
                     {
                         emplist[i].id = "-1";
                          err.Add(i);            
                     }
                   }
            }
          
            return err;
        }
    }
}
