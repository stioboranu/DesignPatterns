namespace ChainOfResponsabilityDP
{
    using System;

    abstract class EmailFilter
    {
        protected EmailFilter? NextFilter { get; set; }

        public void SetNextFilter(EmailFilter filter)
        {
            NextFilter = filter;
        }

        public abstract void Process(Email email);
    }

    class SpamFilter : EmailFilter
    {
        public override void Process(Email email)
        {
            if (email.Content.Contains("buy now"))
            {
                Console.WriteLine("Spam detected!");
            }
            if (NextFilter != null)
            {
                NextFilter.Process(email);
            }
        }
    }

    class VirusFilter : EmailFilter
    {
        public override void Process(Email email)
        {
            if (email.Content.Contains("virus"))
            {
                Console.WriteLine("Virus detected!");
            }
            if (NextFilter != null)
            {
                NextFilter.Process(email);
            }
        }
    }

    class ContentFilter : EmailFilter
    {
        public override void Process(Email email)
        {
            if (email.Content.Contains("bad word"))
            {
                Console.WriteLine("Inappropriate content detected!");
            }
            if (NextFilter != null)
            {
                NextFilter.Process(email);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Email email = new Email("Check out our new product! Buy now and get 50% off!");

            EmailFilter filterChain = BuildFilterChain();

            filterChain.Process(email);
        }

        static EmailFilter BuildFilterChain()
        {
            SpamFilter spamFilter = new SpamFilter();
            VirusFilter virusFilter = new VirusFilter();
            ContentFilter contentFilter = new ContentFilter();

            spamFilter.SetNextFilter(virusFilter);
            virusFilter.SetNextFilter(contentFilter);

            return spamFilter;
        }
    }

}
