using App.Data.Entities.Base;
using App.Share.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppSourceCode : AppEntityBase
	{
		public SourceCodeType SourceCodeType { get; set; }
		public string Name { get; set; }
		public int OwnerUserId { get; set; }
		
		public AppUser OwnerUser { get; set; }
	}
}
