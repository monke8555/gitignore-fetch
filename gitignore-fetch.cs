using System;
using System.IO;
using System.Net;
					
public class Program
{
	public static int Main(string[] args)
	{
		if (args.Length == 0) {
			Console.Write("Which Language/IDE/Framework do you need the .gitignore for? ");
			string gitignoreToGet = Console.ReadLine();
			try {
				string BaseURL = "https://raw.githubusercontent.com/github/gitignore/master/";
				WebClient client = new WebClient();
				ServicePointManager.Expect100Continue = true;                
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string gitignore = client.DownloadString(BaseURL + gitignoreToGet + ".gitignore");
				Console.WriteLine(gitignore);
			} catch (Exception e) {
				if (e.GetType() == new WebException().GetType()) {
					Console.WriteLine("No gitignore was found for \"" + gitignoreToGet + "\"");
				}
			}
		} else if (args.Length == 1) {
			string gitignoreToGet = args[0];
			string gitignore;
			try {
				string BaseURL = "https://raw.githubusercontent.com/github/gitignore/master/";
				WebClient client = new WebClient();
				ServicePointManager.Expect100Continue = true;                
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				gitignore = client.DownloadString(BaseURL + gitignoreToGet + ".gitignore");
			} catch (Exception e) {
				if (e.GetType() == new WebException().GetType()) {
					Console.WriteLine("No gitignore was found for " + gitignoreToGet);
				}
				return 0;
			}
			File.WriteAllText(Directory.GetCurrentDirectory()+"\\.gitignore",gitignore);
			Console.WriteLine(Directory.GetCurrentDirectory()+"\\.gitignore");
		}
		
		return 0;
	}
}
