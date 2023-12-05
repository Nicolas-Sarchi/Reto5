// See https://aka.ms/new-console-template for more information
static int MinNum (int samDaily, int KellyDaily, int Diff)
{
    if (samDaily < 0 || KellyDaily >100 || Diff < 0 || Diff > 100){
        return -1;
    }
    else{
        int samsolved = Diff;
        int kellysolved = 0;

        int days = 0;

        while (samsolved >= kellysolved){
            samsolved += samDaily;
            kellysolved += KellyDaily;
            days++;
        }

        return days;

    }
}

Console.WriteLine (MinNum(4,5,1));
