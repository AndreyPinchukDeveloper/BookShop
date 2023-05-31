﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainLibrary
{
    public interface IBookRepository
    {
        Book[] GetAllByTitle(string title);//Use List 
    }
}
