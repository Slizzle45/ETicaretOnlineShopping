﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
	public class PersonellerUpdateDTO:BaseListDTO
	{
		public string PersonelAdi { get; set; }
		public string PersonelSoyadi { get; set; }
		public string Cinsiyet { get; set; }
		public decimal PersonelMaasi { get; set; }
		public bool MedeniHali { get; set; }
		public string CalistigiFirma { get; set; }
		public string Hakkinda { get; set; }
		public string YasadigiSehir { get; set; }
		
		
	}
}
