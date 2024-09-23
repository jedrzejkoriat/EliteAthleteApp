﻿using System.ComponentModel.DataAnnotations;

namespace TrainingPlanApp.Web.Models
{
	public class TrainingPlanDetailsVM
	{
		// IDs
		public int? Id { get; set; }

		[Display(Name = "Athlete")]
		public string? UserId { get; set; }

		// STRINGS etc.
		[Display(Name = "Training Plan")]
		public string? Name { get; set; }

		[Display(Name = "Description")]
		public string? Description { get; set; }

		// LISTS
		public List<ExerciseVM?>? Exercises { get; set; }
		public List<int?>? ExerciseIds { get; set; }
		public List<int?>? Weight { get; set; }
		public List<int?>? Sets { get; set; }
		public List<int?>? Repeats { get; set; }
		public List<string?>? Index { get; set; }
	}
}
