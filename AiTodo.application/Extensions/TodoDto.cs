using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AiTodo.application.Extensions
{
    public class TodoDto
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "insert Description")]
        public string Description { get; set; } = string.Empty;
    }
}