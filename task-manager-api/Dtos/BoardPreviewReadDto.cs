﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_manager_api.Dtos
{
    public class BoardPreviewReadDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsEmpty { get; set; }
    }
}
