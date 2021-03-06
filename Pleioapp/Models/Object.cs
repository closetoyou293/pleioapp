﻿using System;
using Newtonsoft.Json;

namespace Pleioapp
{
	public class Object
	{
		string _iconUrl;

		[JsonProperty]
		public string guid { get; set; }

		[JsonProperty(PropertyName="time_created")]
		public DateTime timeCreated { get; set; }

		[JsonProperty]
		public string title { get; set; }

		[JsonProperty]
		public string description { get; set; }

		[JsonProperty]
		public string type { get; set; }

		[JsonProperty]
		public string url { get; set; }

		[JsonProperty(PropertyName="icon_url")]
		public string iconUrl {
			get { return _iconUrl + "?guid=" + guid; }
			set { _iconUrl = value; }
		}

		public string humanReadableType { 
			get {
			switch (type) {
				case "blog":
					return "blog";
				case "question":
					return "vraag";
				case "file":
					return "bestand";
				case "thewire":
					return "bericht";
				case "page_top":
					return "pagina";
				case  "page":
					return "pagina";
				case "bookmarks":
					return "favoriete pagina";
				default:
					return type;
			}}
		}
	}
}

