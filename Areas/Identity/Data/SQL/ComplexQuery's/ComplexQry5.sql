Select O.QuantityOrdered , I.Price, O.ItemID,I.ItemName
from [Order] AS O,Item AS i
Where O.ItemID = I.ItemID
and QuantityOrdered >= 200 and price >= 10
order by ItemID desc