﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using BookApp.Persistence.EfCoreSql.Books;

namespace BookApp.ServiceLayer.DefaultSql.Books.Services
{
    public class SoftDeleteService
    {
        private BookDbContext _context;

        public SoftDeleteService(BookDbContext context)
        {
            _context = context;
        }


    }
}