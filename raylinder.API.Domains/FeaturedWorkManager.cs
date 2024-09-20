
using raylinder.Models;

namespace raylinder.API.Domains;
public class FeaturedWorkManager : IFeaturedWorkManager
{
    public async Task<IEnumerable<WorkProject>> GetWorkProjects()
    {
        return await LoadWorkProjects();
    }

    private Task<IEnumerable<WorkProject>> LoadWorkProjects()
    {
        IEnumerable<WorkProject> workProjects = new List<WorkProject>
        {
            new() {
                Title = "Seacret and Club Seacret - The Good Life Is Here",
                Description = "Discover incredible natural wonders of world-famous Dead Sea minerals. Find nourishing skin care & beauty products: masks, creams, serums & more!",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1706620000694.jpg",
                WebsiteUrl = "https://www.seacretdirect.com/www/en/us/"
            },
            new() {
                Title = "adorelogic - Connect. Family. Together.",
                Description = "Kin of Us is a family social network where you and your family members can enjoy memorable moments, share family stories, and savor delicious recipes. Learn more... JobPin is a platform to help organize your job opportunities or 'pins'. You can create...",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1706619770339.jpg",
                WebsiteUrl = "http://www.adorelogic.com/"
            },
            new() {
                Title = "Talking Stick Resort - Scottsdale, AZ",
                Description = "Book your stay at our luxurious Four-Diamond Phoenix area resort & experience the very best of Scottsdale, AZ.",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1710988466546.jpg",
                WebsiteUrl = "https://www.talkingstickresort.com/"
            },
            new() {
                Title = "Release Pool Party | Talking Stick Resort, Scottsdale AZ",
                Description = "Voted one of the Best Valley Pool Parties of 2014. Release Pool Parties only at Talking Stick Resort - Scottsdale, Arizona.",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1706620104493.jpg",
                WebsiteUrl = "https://www.releasevip.com/"
            },
            new() {
                Title = "AgilityHealth | Accelerate Digital and Agile Talent Development",
                Description = "Leverage measurement to accelerate your Digital talent and scale your enterprise agility transformation",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1711472402419.jpg",
                WebsiteUrl = "https://agilityhealthradar.com/"
            },
            new() {
                Title = "Digital Air Strike - Scottsdale, AZ",
                Description = "HQ in Scottsdale, AZ, Digital Air Strike's social media marketing, online reputation management, and lead response solutions deliver real ROI for thousands of businesses in automotive, education, healthcare, retail, and more. ",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1706619839770.jpg",
                WebsiteUrl = "https://digitalairstrike.com/"
            },
            new() {
                Title = "Isagenix - The Art of Wellbeing",
                Description = "Welcome to Isagenix! You’re the one we’ve been waiting for! Isagenix is your opportunity for health, wealth and happiness.",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1706620251921.jpg",
                WebsiteUrl = "https://www.isagenix.com/"
            },
            new() {
                Title = "Navy SBIR/STTR Programs",
                Description = "The Navy SBIR program provides federal funding to ensure American small businesses are part of Naval research and development.",
                ImageUrl = "https://raylinderstorage.blob.core.windows.net/assets/1726615074081.jpg",
                WebsiteUrl = "https://www.navysbirprogram.com/"
            }
        };

        return Task.FromResult(workProjects);
    }
}
