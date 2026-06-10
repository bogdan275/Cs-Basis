using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Data
{
    public interface ICustomerManager
    {
        List<Customer> Read(string path);
        void Write(string path, List<Customer> customers);
    }
}
