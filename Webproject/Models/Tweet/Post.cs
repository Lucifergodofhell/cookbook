using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Webproject.Models.Tweet
{
    public class Post
    {
		[Key]
		public string TweetID { get; set; }
		public string Tweet { get; set; }
		public string UserId { get; set; }
		public bool istweet { get; set; }
	}
}
