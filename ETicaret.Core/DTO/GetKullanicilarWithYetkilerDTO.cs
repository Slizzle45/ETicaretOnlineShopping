﻿using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
	public class GetKullanicilarWithYetkilerDTO:BaseListDTO
	{
		public Kullanicilar kullanicilar { get; set; }

		public Yetkiler yetkiler { get; set; }

		 
	}
}
