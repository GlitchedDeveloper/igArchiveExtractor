﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGAE_GUI
{
	struct IGAE_FileDescHeader
	{
		public uint startingAddress;
		public uint size;
		public string path;
		public uint index;
		public uint mode;
	}
}
