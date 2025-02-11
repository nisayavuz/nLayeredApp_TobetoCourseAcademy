﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
	public static class BusinessServiceRegistration
	{

		public static IServiceCollection AddBusinessServices(this IServiceCollection services)
		{
			services.AddScoped<ICategoryService, CategoryManager>();
			services.AddScoped<ICourseService, CourseManager>();
			services.AddScoped<IInstructorService, InstructorManager>();
			return services;
		}

	}
}
