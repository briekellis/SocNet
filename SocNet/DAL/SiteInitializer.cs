using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SocNet.Models;

namespace SocNet.DAL
{
    public class SiteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SiteContext>
    {
        protected override void Seed(SiteContext context)
        {
            var projects = new List<Project>
            {
                new Project{ID=1, ProjectTitle="SocialNet", Description="An ASP.NET web application for IT students and professionals to use for posting events and projects", Requirements="Experience with ASP.NET and Bootstrap a bonus, but not required.", Location="NMC, Traverse City, Michigan"},
                new Project{ID=2, ProjectTitle="Infrastructure Analysis", Description="A opportunity for infrastructure students to see a real, operating environment and analyze the current gaps in the layout.", Requirements="Must be a student studying CIT infrastructure or similar course of study", Location="That One Business, Neverland"},
                new Project{ID=3, ProjectTitle="Cool Beans", Description="A startup for developing an application for coffee shops to track and analyze coffee bean and tea usages", Requirements="Experience with OOP and C#", Location="Cool Beans, Grand Rapids, Michigan"}
            };

            projects.ForEach(p => context.Projects.Add(p));
            context.SaveChanges();

            var events = new List<Event>
            {
                new Event{ID=1, EventTitle="Pro Network Event", Description="An opportunity for IT professionals and students to meet and network with eachother to exchange ideas and experiences. Pizza and drinks will be available.", Cost=10.00, Location="Brew Coffee Shop, Traverse City, Michigan"},
                new Event{ID=1, EventTitle="AI/ML Tech Forum", Description="A forum for those interested in learning more about artificial intelligence and machine learning", Cost=15.00, Location="The DeVos Place, Grand Rapids, Michigan"},
                new Event{ID=1, EventTitle="Industry Night Out", Description="An event for students to attend for social networking and professional development points", Cost=0.00, Location="Nafety Set, Traverse City, Michigan"}
            };
            events.ForEach(p => context.Events.Add(p));
            context.SaveChanges();
        }
    }
}