
using raylinder.Entities;

namespace raylinder.Data;
public class ExperienceData
{
    public IEnumerable<WorkExperience> WorkExperiences { get; set; }
    public IEnumerable<WorkExperienceDescription>? WorkExperienceDescriptions { get; set; }
    public IEnumerable<Skill> Skills { get; set; }

    public ExperienceData()
    {
        WorkExperiences = WorkExperiencesData;
        WorkExperienceDescriptions = WorkExperienceDescriptionsData;
        Skills = SkillsData;
    }

    private IEnumerable<WorkExperience> WorkExperiencesData = new List<WorkExperience>
    {
        new ()
        {
            Id = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}"),
            Title = "Senior Software Engineer.",
            CompanyName = "Adorelogic",
            Dates = "01/2018 - 06/2024",
            Location = "Remote (Scottsdale, AZ & The Woodlands, TX)",
            ImageUrl = "/img/android-chrome-192x192.png",
            Alignment = "Left",
            ParentId = Guid.Empty
        },
        new ()
        {
            Id = Guid.Parse("{9468EFBE-6DE6-42C8-B711-4370FE3A162D}"),
            Title = "SOFTWARE ENGINEER III.",
            CompanyName = "Digital Air Strike",
            Dates = "04/2017 - 01/2018",
            Location = "Scottsdale, AZ",
            ImageUrl = "/img/digitalairstrike_com_wp_wp-content_themes_divi-child_images_logo.png",
            Alignment = "Right",
            ParentId = Guid.Empty
        },
        new ()
        {
            Id = Guid.Parse("{AF8D99B1-C84C-4356-809D-4A455397B65A}"),
            Title = "SENIOR WEB DEVELOPER.",
            CompanyName = "LaneTerralever",
            Dates = "08/2016 - 02/2017",
            Location = "Phoenix, AZ",
            ImageUrl = "/img/www_laneterralever_com_hubfs_logo.png",
            Alignment = "Left",
            ParentId = Guid.Empty
        },
        new ()
        {
            Id = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}"),
            Title = "SENIOR .NET DEVELOPER.",
            CompanyName = "RIESTER",
            Dates = "08/2015 - 08/2016",
            Location = "Phoenix, AZ",
            ImageUrl = "/img/www_riester_com_contact.png",
            Alignment = "Right",
            ParentId = Guid.Empty
        },
        new ()
        {
            Id = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}"),
            Title = "SENIOR SOFTWARE DEVELOPER - CONSULTANT/CONTRACTS.",
            CompanyName = "",
            Dates = "02/2011 - 08/2015",
            Location = "",
            ImageUrl = "/img/adobestock_318962839.jpg",
            Alignment = "Left",
            ParentId = Guid.Empty
        },
        new ()
        {
            Id = Guid.Parse("{0B67C98E-3B1D-4F57-922A-0A8FFFD94CBC}"),
            Title = "",
            CompanyName = "Seacret Direct, LLC",
            Dates = "",
            Location = "Phoenix, AZ",
            ImageUrl = "",
            Alignment = "",
            ParentId = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}")
        },
        new ()
        {
            Id = Guid.Parse("{90500024-FF8E-4F2A-895D-DEFCBD6A070B}"),
            Title = "",
            CompanyName = "Time America, Inc",
            Dates = "",
            Location = "Scottsdale, AZ",
            ImageUrl = "",
            Alignment = "",
            ParentId = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}")
        },
        new ()
        {
            Id = Guid.Parse("{0A1EA3B8-FB43-4C71-81D6-B98501476DD4}"),
            Title = "",
            CompanyName = "TBConsulting, LLC",
            Dates = "",
            Location = "Scottsdale, AZ",
            ImageUrl = "",
            Alignment = "",
            ParentId = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}")
        },
        new ()
        {
            Id = Guid.Parse("{A0E1DE38-E6A2-4DAF-8AEA-CD03455B1C83}"),
            Title = "",
            CompanyName = "EMarketing/Prizelogic",
            Dates = "",
            Location = "Scottsdale, AZ",
            ImageUrl = "",
            Alignment = "",
            ParentId = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}")
        },
        new ()
        {
            Id = Guid.Parse("{3380D003-B145-4486-95E8-21ECBD41AA68}"),
            Title = "",
            CompanyName = "Arizona Department of Transportation (ADOT)",
            Dates = "",
            Location = "Phoenix, AZ",
            ImageUrl = "",
            Alignment = "",
            ParentId = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}")
        },
        new ()
        {
            Id = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}"),
            Title = "",
            CompanyName = "Navajo Nation Reservation",
            Dates = "",
            Location = "Window Rock, AZ",
            ImageUrl = "",
            Alignment = "",
            ParentId = Guid.Parse("{6D5FC22D-708B-4C8B-ADDB-149FA4C3CF27}")
        },
        new ()
        {
            Id = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}"),
            Title = "SENIOR WEB DEVELOPER.",
            CompanyName = "Glasci",
            Dates = "05/2004 - 02/2011",
            Location = "Window Rock, AZ",
            ImageUrl = "",
            Alignment = "Right",
            ParentId = Guid.Empty
        }
    };

    private IEnumerable<WorkExperienceDescription> WorkExperienceDescriptionsData = new List<WorkExperienceDescription>
    {
        new()
        {
            Description = "Evaluated code and led refactoring initiatives, offering technical guidance to team members.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Supported development initiatives by overseeing Neo4j-based solution designs and guided team members using Neo4j-backed graph databases.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Engaged in hands-on development and maintenance of user-facing websites, utilizing technologies such as Blazor, ASP.NET MVC/Web API, .NET Core, RESTful/API services with token authentication, and the .NET Neo4j layer for Neo4j graph database access.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Championed adopting in-house and industry advances in software development practices and standards.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Demonstrated recognized expertise and strategic thinking in my designated areas, emphasizing a big-picture and visionary approach.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Spearheaded the implementation of Neo4j as a powerful solution to meet collaboration and related data requirements.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Proficient in data access principles and skilled in database design for graph and relational databases using Neo4j (Cypher) and SQL Server (T-SQL).",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Utilized a variety of technologies, including HTML5, CSS3, jQuery, Blazor, ASP.NET Core, C#, Entity Framework Core, PowerShell, and microservices (RESTful APIs) for the development of web-based product applications.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Established and managed cloud-based environments using Microsoft Azure services, including Azure Storage (Queue and Blobs), Azure App Services, and Azure SQL environments.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Created internal documentation outlining cloud-based infrastructures and web application configurations, and set up and maintained CI/CD environments.",
            WorkExperienceId = Guid.Parse("{7F04FF07-76F1-4BD5-ABCD-ACE1D186F124}")
        },
        new()
        {
            Description = "Crafted and upheld web applications for a diverse range of automotive dealership clients, encompassing names like GMC, Honda, and Toyota. These applications were developed using technologies such as ASP.NET MVC, ASP.NET Core, and RESTful/API services.",
            WorkExperienceId = Guid.Parse("{9468EFBE-6DE6-42C8-B711-4370FE3A162D}")
        },
        new()
        {
            Description = "Leveraged a comprehensive tech stack that included HTML5, CSS3, jQuery, React.js, ASP.NET MVC, ASP.NET Core, C#, T-SQL, PowerShell, and XSLT to generate ad hoc reports for a client.",
            WorkExperienceId = Guid.Parse("{9468EFBE-6DE6-42C8-B711-4370FE3A162D}")
        },
        new()
        {
            Description = "Employed databases like Microsoft SQL Server, MySQL, and MongoDB to engineer web-based product applications for clients, adhering to essential principles such as CQRS and Domain-Driven Design.",
            WorkExperienceId = Guid.Parse("{9468EFBE-6DE6-42C8-B711-4370FE3A162D}")
        },
        new()
        {
            Description = "Established and managed cloud-based environments through Microsoft Azure services, catering to clients' requirements that spanned Azure Storage (Queue and Blobs), Azure App Services, Azure SQL, Azure VM/ARM environments, Azure Microservices, Docker containers, and more.",
            WorkExperienceId = Guid.Parse("{9468EFBE-6DE6-42C8-B711-4370FE3A162D}")
        },
        new()
        {
            Description = "Utilized object-oriented programming principles for developing high-quality software components using ASP.NET MVC, Umbraco, Sitecore, and Sitefinity for multiple clients.",
            WorkExperienceId = Guid.Parse("{AF8D99B1-C84C-4356-809D-4A455397B65A}")
        },
        new()
        {
            Description = "Maintained a source control system for tracking project progress and changes made to the source code base over time.",
            WorkExperienceId = Guid.Parse("{AF8D99B1-C84C-4356-809D-4A455397B65A}")
        },
        new()
        {
            Description = "Deployed applications from the development environment to test and production environments following established release management processes.",
            WorkExperienceId = Guid.Parse("{AF8D99B1-C84C-4356-809D-4A455397B65A}")
        },
        new()
        {
            Description = "Designed and managed web applications for diverse clients, employing cutting-edge technologies like ASP.NET MVC, Umbraco CMS, Salesforce's Sales Cloud, and ExactTarget.",
            WorkExperienceId = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}")
        },
        new()
        {
            Description = "Leveraged HTML5, CSS3, jQuery, ASP.NET MVC, C#, and Microsoft SQL Server (T-SQL) to craft all web-based applications for clients.",
            WorkExperienceId = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}")
        },
        new()
        {
            Description = "Established and maintained cloud-based ecosystems through Microsoft Azure services, ensuring seamless operations for clients.",
            WorkExperienceId = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}")
        },
        new()
        {
            Description = "Implemented and orchestrated Azure SQL database backups and executed web application analytics configuration for clients.",
            WorkExperienceId = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}")
        },
        new()
        {
            Description = "Offered development progress updates and extended support to fellow developers and designers.",
            WorkExperienceId = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}")
        },
        new()
        {
            Description = "Achieved project completion within designated development timeframes and allocated budgets, demonstrating strong project management abilities.",
            WorkExperienceId = Guid.Parse("{81485964-CED8-4143-B5CD-11BADB419A53}")
        },
        new()
        {
            Description = "Heavily utilized HTML5, CSS3, jQuery, ASP.NET MVC, C#, and Microsoft SQL Server (T-SQL) to develop and design all web-based systems.",
            WorkExperienceId = Guid.Parse("{0B67C98E-3B1D-4F57-922A-0A8FFFD94CBC}")
        },
        new()
        {
            Description = "Simultaneously developed and maintained multiple web-based products, web applications, and internal applications using .NET technologies.",
            WorkExperienceId = Guid.Parse("{0B67C98E-3B1D-4F57-922A-0A8FFFD94CBC}")
        },
        new()
        {
            Description = "Updated existing products by documenting, coding, testing, and debugging applications.",
            WorkExperienceId = Guid.Parse("{0B67C98E-3B1D-4F57-922A-0A8FFFD94CBC}")
        },
        new()
        {
            Description = "Updated web-based user experience with fresh designs and client-side functionality for the company's flagship products.",
            WorkExperienceId = Guid.Parse("{0B67C98E-3B1D-4F57-922A-0A8FFFD94CBC}")
        },
        new()
        {
            Description = "Developed and maintained company web-based products, web applications, and internal applications using .NET technologies.",
            WorkExperienceId = Guid.Parse("{90500024-FF8E-4F2A-895D-DEFCBD6A070B}")
        },
        new()
        {
            Description = "Developed and maintained the company's cloud-based infrastructure using Microsoft Azure services for clientele expansion.",
            WorkExperienceId = Guid.Parse("{90500024-FF8E-4F2A-895D-DEFCBD6A070B}")
        },
        new()
        {
            Description = "Developed and configured virtual environments for disaster recovery using Microsoft Azure cloud services.",
            WorkExperienceId = Guid.Parse("{90500024-FF8E-4F2A-895D-DEFCBD6A070B}")
        },
        new()
        {
            Description = "Created full-scale and detailed documentation of the company's entire cloud-based infrastructure.",
            WorkExperienceId = Guid.Parse("{90500024-FF8E-4F2A-895D-DEFCBD6A070B}")
        },
        new()
        {
            Description = "Heavily utilized Powershell to set up server environments.",
            WorkExperienceId = Guid.Parse("{90500024-FF8E-4F2A-895D-DEFCBD6A070B}")
        },
        new()
        {
            Description = "Developed multiple projects for clients such as the Arizona Board of Appraisers, SafeGuard, My Better Business Reviews, & TriWest.",
            WorkExperienceId = Guid.Parse("{0A1EA3B8-FB43-4C71-81D6-B98501476DD4}")
        },
        new()
        {
            Description = "Developed flow-based web applications and workflows in ASP.NET MVC using Windows Azure services, Bootstrap, jQuery, Knockout, and other front-end technologies.",
            WorkExperienceId = Guid.Parse("{0A1EA3B8-FB43-4C71-81D6-B98501476DD4}")
        },
        new()
        {
            Description = "Implemented Web, Microsoft SQL Server clusters, & Windows Azure VM servers for QA testing and production.",
            WorkExperienceId = Guid.Parse("{0A1EA3B8-FB43-4C71-81D6-B98501476DD4}")
        },
        new()
        {
            Description = "Simultaneously worked on multiple projects for clients such as Quaker, Subway, HGTV, OshKosh, Gamestop, T-Mobile, Walmart, Clorox, Zillow, Travelocity, Jennie-O, Dollar General, and Starbucks.",
            WorkExperienceId = Guid.Parse("{A0E1DE38-E6A2-4DAF-8AEA-CD03455B1C83}")
        },
        new()
        {
            Description = "Worked on projects such as instant wins, sweepstakes, user-generated content submissions, Facebook applications, and employee training trivia for mobile devices and tablets in a 1–2-week development time.",
            WorkExperienceId = Guid.Parse("{A0E1DE38-E6A2-4DAF-8AEA-CD03455B1C83}")
        },
        new()
        {
            Description = "Created browser, unit, and system tests, and logs, and managed site launches with deployment teams.",
            WorkExperienceId = Guid.Parse("{A0E1DE38-E6A2-4DAF-8AEA-CD03455B1C83}")
        },
        new()
        {
            Description = "Developed flow-based web applications and workflows in ASP.NET MVC while utilizing T4 templates and scaffolds.",
            WorkExperienceId = Guid.Parse("{A0E1DE38-E6A2-4DAF-8AEA-CD03455B1C83}")
        },
        new()
        {
            Description = "Heavily utilized HTML5, CSS3, jQuery, ASP.NET MVC, C#, Knockout.js, and Microsoft SQL Server (T-SQL) to develop and design all web-based systems using Microsoft's Metro UI design specifications.",
            WorkExperienceId = Guid.Parse("{3380D003-B145-4486-95E8-21ECBD41AA68}")
        },
        new()
        {
            Description = "Developed and designed intranet systems for government departments and provided support to 100+ employees & customers.",
            WorkExperienceId = Guid.Parse("{3380D003-B145-4486-95E8-21ECBD41AA68}")
        },
        new()
        {
            Description = "Provided development status and support to 100+ department employees.",
            WorkExperienceId = Guid.Parse("{3380D003-B145-4486-95E8-21ECBD41AA68}")
        },
        new()
        {
            Description = "Trained employees in the knowledge of Entity Framework, C#, jQuery, HTML5, and ASP.NET MVC.",
            WorkExperienceId = Guid.Parse("{3380D003-B145-4486-95E8-21ECBD41AA68}")
        },
        new()
        {
            Description = "Developed and designed intranet systems for tribal departments and provided support to 100+ employees.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Provided development status and support to 100+ department employees.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Administered servers, networks, and software for 5 tribal departments.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Designed and developed different educational websites with graphical illustrations and animated tutorials.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Prepared estimates of cost, effort, and duration for development tasks and activities.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Developed websites using ASP.NET, ASP.NET MVC, C#, WCF, XSLT Editor to ad hoc reports, Microsoft SQL Server (T-SQL), Oracle, and MySQL for various projects.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Designed and developed system, application, and program code according to business and technical requirements, OWASP standards (Injection, Cross-Site Scripting (XSS), Broken Authentication and Session Management.",
            WorkExperienceId = Guid.Parse("{BA0864D6-E3D6-4971-9BB6-EF167FEA3B13}")
        },
        new()
        {
            Description = "Heavily utilized jQuery, ASP.NET MVC, C#, and Microsoft SQL Server (T-SQL) to develop and design all web-based systems using Microsoft's Metro UI design specifications.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        },
        new()
        {
            Description = "Analyzed requirements and design solutions for approved projects and change requests of high complexity and risk.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        },
        new()
        {
            Description = "Provided development status and support to team developers and designers.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        },
        new()
        {
            Description = "Utilized Microsoft's cloud service Windows Azure production environment.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        },
        new()
        {
            Description = "Assigned various duties including Web page maintenance and design using Agile/Scrum management.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        },
        new()
        {
            Description = "Broad clientèle with a heavy emphasis on new business development and partial sales responsibilities.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        },
        new()
        {
            Description = "Built test/beta projects using pre-releases of HTML5, CSS3, jQuery, ASP.NET MVC, and C# using Microsoft's Metro UI design specifications along with TDD methodologies.",
            WorkExperienceId = Guid.Parse("{803755C6-4F3D-47AA-9940-9D465867B63C}")
        }
    };

    private IEnumerable<Skill> SkillsData = new List<Skill>
    {
        new ()
        {
            Name = "Blazor",
            Year = 2018
        },
        new ()
        {
            Name = "React",
            Year = 2017
        },
        new ()
        {
            Name = "Angular",
            Year = 2017
        },
        new ()
        {
            Name = "ASP.NET Core",
            Year = 2016
        },
        new ()
        {
            Name = "ASP.NET MVC",
            Year = 2011
        },
        new ()
        {
            Name = "ASP.NET Web API",
            Year = 2012
        },
        new ()
        {
            Name = "ASP.NET Web Forms",
            Year = 2004
        },
        new ()
        {
            Name = "C#",
            Year = 2004
        },
        new ()
        {
            Name = "Microsoft SQL Server",
            Year = 2004
        },
        new ()
        {
            Name = "Neo4j",
            Year = 2018
        },
        new ()
        {
            Name = "Web Service API",
            Year = 2010
        }
    };
}
