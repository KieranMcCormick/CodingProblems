
Decide, of all possible buy and sell dates, which two are best

To choose, you must select: from the *best* previous buy date, through all buy dates until the current sell date, what is most profitable
INDEX: 1 2 3 4 5 6 7 
VALUE: 1 2 1 2 7 2 9 
       B S B   S B S
           bb*     ^-currentIndex

In this example, we see that there are three buy dates. Index 1, 3, and 6

And we can see there are three Sell dates 2, 5, and 7

Up to this index, we have been able to decide that the buy/sell [1,2]=1 is in the previous buy/sell section

now, we can see that there are three new buy/sell options in the current buy/sell section
[3,5]=6, [6,7]=7 and [3,7]=8

Since we are now at the end, We need to decide which two will give us the best profit

we compare the prev profit, [1,2], plus the profit of the prev best sell with the end of the current prev best sell section, [3,7]

with all possible combos of the non intersecting dates
    [1,2], [3,5]
    [1,2], [6,7]
    [3,5], [6,7]

In this case, when we reach index 7 and want to sell, we need to determine if the best previous buy date (index 3 marked bb) is the best choice
We want to buy/sell on [3,5] and [6,7] to profit 13

New sell dates are set whenever the current day has a lower price than the current best buy date.

Also need to keep track of other low sell dates

Each time we set a new buy, (and therefore lock in a sell date) we need to calculate the 

what about each time we set a new lowest sell date?
- calc all prev buy dates for the prev best sell?

do the same when we reach the end of the list.

in each section, we keep track of the profit of the best buy/sell, and the profit of the best two buy/sell
index 0 of the section is profit of the best buy/sell, index 0 is the profit of the best two buy/sell
-1 in index 1 == no best two.

       (s1)=1,-1    (s2)=8,13      (s3)=3,-1
INDEX: 1  2       | 3 4 5 6 7     | 8 9 10 11
VALUE: 4  5       | 1 2 7 2 9     | 1 4 3  3
       B  S       | B   S B S     | B S B
       bb*        | bb*           | bb*        
                                            ^-currentIndex

----------------------------------------------------------------

List prices = new List<int>["numbers be here"];


// Setup
// List to keep track of best profit
// ....Value Array
List VA = new List<int>[-1,-1];

// List to keep track of current lowest price
// ....Smallest Array
List SA = new List<int>[-1,-1];

// Index to keep track of current best sell day
List LA = new List<int>[-1,-1];

// Index to keep track of current index in VA & SA
// We increment this when we choose to buy again
int n = 0;

int lowestPreviousSellDate = -1;

// Base Step
if(prices.len<2) return "Not Buying";

// Choose starting indexies for s and l
if (prices[1] > prices[0]) SA[n] = 0, LA[n] = 1;
else LA[n] = 0;

for(int i = 2, i < prices.len, i++)
{
    // Check for new low or to init high while L isn't set
    if(L == -1)
    {
        // Move S to better buy day
        if(prices[i] < prices[SA[n]])
        {
            SA[n] = i;
        }
        // Init L
        else if(prices[i] > prices[SA[n]])
        {
            LA[n] = i;
        }
    }
    // Check for increasing L or setting profit
    else if()
    {

    }
}

