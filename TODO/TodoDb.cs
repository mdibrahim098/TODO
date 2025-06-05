﻿using Microsoft.EntityFrameworkCore;

namespace TODO
{
    public class TodoDb :DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
