select Round(Avg(Price), 2) as AveragePrice
from Item
order by AveragePrice desc