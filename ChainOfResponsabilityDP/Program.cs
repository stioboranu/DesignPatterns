using ChainOfResponsabilityDP;

Email email = new Email("Check out our new buy now virus bad word product! Buy now and get 50% off!");

//// Spam filter
//if (email.Content.Contains("buy now"))
//{
//    Console.WriteLine("Spam detected!");
//}
//else
//{
//    // Virus filter
//    if (email.Content.Contains("virus"))
//    {
//        Console.WriteLine("Virus detected!");
//    }
//    else
//    {
//        // Content filter
//        if (email.Content.Contains("bad word"))
//        {
//            Console.WriteLine("Inappropriate content detected!");
//        }
//        else
//        {
//            Console.WriteLine("No spam, virus, or inappropriate content detected.");
//        }
//    }
//}


EmailFilter filterChain = BuildFilterChain();
filterChain.Process(email);

EmailFilter BuildFilterChain()
{
    SpamFilter spamFilter = new SpamFilter();
    VirusFilter virusFilter = new VirusFilter();
    ContentFilter contentFilter = new ContentFilter();

    spamFilter.SetNextFilter(virusFilter);
    virusFilter.SetNextFilter(contentFilter);

    return spamFilter;
}

class Email
{
    public string Content { get; set; }

    public Email(string content)
    {
        Content = content;
    }
}

