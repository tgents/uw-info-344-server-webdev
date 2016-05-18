﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace hw3test
{
    class Program
    {

        static void Main(string[] args)
        {
            //Uri baseUri = new Uri("http://cnn.com");
            //HashSet<Uri> urls = new HashSet<Uri>();
            //urls.Add(baseUri);
            //HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load("http://cnn.com");
            //HtmlNode lastmod = doc.DocumentNode.SelectSingleNode("//title");
            //Console.WriteLine(lastmod.InnerText);
            ////HtmlNodeCollection hrefs = doc.DocumentNode.SelectNodes("//a[@href]");
            ////HtmlNode lastmod = doc.DocumentNode.SelectSingleNode("//meta[@name='lastmod']");
            ////lastmod.GetAttributeValue("content", "");
            ////foreach (HtmlNode links in hrefs)
            ////{
            ////    var relativeUris = links.Attributes
            ////        .Select(x => x)
            ////        .Where(x => x.Name == "href")
            ////        .Where(x => x.Value.StartsWith("/"))
            ////        .Where(x => !x.Value.StartsWith("//"));
            ////    foreach(HtmlAttribute item in relativeUris)
            ////    {
            ////        urls.Add(new Uri(baseUri, item.Value));
            ////    }                
            ////}

            //XmlDocument xmldoc = new XmlDocument();
            //xmldoc.Load("http://www.cnn.com/sitemaps/sitemap-specials-2016-04.xml");
            //string childname = xmldoc.LastChild.Name;
            //DateTime compare = Convert.ToDateTime("2016-04-01");
            //Console.WriteLine(compare.ToString());
            //List<Uri> mockxml = new List<Uri>();
            //List<Uri> mockhtml = new List<Uri>();
            //if (childname.Equals("sitemapindex") || childname.Equals("urlset"))
            //{
            //    foreach (XmlNode sitemap in xmldoc.LastChild.ChildNodes)
            //    {
            //        string url = "";
            //        string date = "";
            //        foreach (XmlNode info in sitemap.ChildNodes)
            //        {
            //            if (info.Name.Equals("loc"))
            //            {
            //                url = info.InnerText;
            //            }
            //            else if (info.Name.Equals("lastmod"))
            //            {
            //                date = info.InnerText;
            //            }
            //        }

            //        if (Convert.ToDateTime(date).CompareTo(compare) >= 0)
            //        {
            //            if (url.EndsWith(".xml"))
            //            {
            //                mockxml.Add(new Uri(url));
            //            }
            //            else
            //            {
            //                mockhtml.Add(new Uri(url));
            //            }
            //        }
            //    }
            //}

            //var webRequest = WebRequest.Create(@"http://cnn.com/robots.txt");

            //var response = webRequest.GetResponse();
            //var content = response.GetResponseStream();
            //var reader = new StreamReader(content);
            //Uri root = new Uri("http://cnn.com");

            //List<Uri> disallow = new List<Uri>();

            //while (!reader.EndOfStream)
            //{
            //    string current = reader.ReadLine();
            //    if (current.StartsWith("sitemap", StringComparison.OrdinalIgnoreCase))
            //    {
            //        string url = current.Substring(current.IndexOf(' '));
            //        mockxml.Add(new Uri(url));
            //    }
            //    else if (current.StartsWith("disallow", StringComparison.OrdinalIgnoreCase))
            //    {
            //        string url = current.Substring(current.IndexOf(' '));
            //        disallow.Add(new Uri(root, url));
            //    }
            //}


            //Uri uri = new Uri("http://www.bleacherreport.com/nba");

            //// Console.WriteLine("http://" + uri.Host + "/nba");
            //DateTime test = new DateTime();
            //DateTime test2 = DateTime.Parse("0");
            //Console.WriteLine(test + " " + test2);

            //Uri uri = new Uri("http://cnn.com");
            //HashSet<Uri> urls = new HashSet<Uri>();

            //HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load(uri.AbsoluteUri);

            //HtmlNodeCollection hrefs = doc.DocumentNode.SelectNodes("//a[@href]");

            //foreach(HtmlNode node in hrefs)
            //{
            //    var nodeAttributes = node.Attributes
            //        .Select(x => x)
            //        .Where(x => x.Name == "href");
            //    foreach(HtmlAttribute link in nodeAttributes)
            //    {
            //        string url = link.Value;
            //        if(url.StartsWith("/") && !url.StartsWith("//"))
            //        {
            //            urls.Add(new Uri("http://" + uri.Host + url));
            //        }
            //        else if (url.StartsWith("http://bleacherreport.com/articles"))
            //        {
            //            urls.Add(new Uri(url));
            //        }
            //    }
            //}

            ////get title
            //HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");
            //string title = "";
            //if (titleNode != null)
            //{
            //    title = titleNode.InnerText;
            //}

            ////get date
            //HtmlNode lastmod = doc.DocumentNode.SelectSingleNode("//meta[@name='lastmod']");
            //string date = "";
            //if (lastmod != null)
            //{
            //    date = lastmod.GetAttributeValue("content", "");
            //}

            //DateTime converteddate = date.Equals("") ? new DateTime() : Convert.ToDateTime(date);

            //Console.WriteLine(uri.AbsoluteUri + " " + title + " " + converteddate.ToString());
            //foreach(Uri u in urls)
            //{
            //    Console.WriteLine(u.AbsoluteUri);
            //}

            WebClient downloader = new WebClient();
            string sitedata = downloader.DownloadString("http://cnn.com");
            Console.WriteLine(sitedata);

            Console.Read();
        }        
    }
}
