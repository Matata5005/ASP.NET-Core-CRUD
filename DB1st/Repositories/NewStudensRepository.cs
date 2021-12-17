/* using DB1st.Data;
using DB1st.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB1st.Models;
using DB1st.Controllers;
using Microsoft.EntityFrameworkCore;

namespace DB1st.Repositories
{
    public class NewStudensRepository : INewStudents
    {
        private readonly ApplicationDbContext _context;
        public NewStudensRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public NewStudents Create(NewStudents student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return student;

        }
        
    }
} */
