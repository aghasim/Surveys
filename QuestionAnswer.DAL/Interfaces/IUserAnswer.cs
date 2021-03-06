﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Entities;

namespace QuestionAnswer.DAL.Interfaces
{
    public interface IUserAnswer<T> where T:class
    {
        //получить все атветы пользователей
        List<T> GetAll(); 
        void Create(List<T> item);
        
    }
}
