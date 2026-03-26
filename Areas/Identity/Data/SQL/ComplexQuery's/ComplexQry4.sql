Select O.QuantityOrdered , IL.Quantity, O.ItemID
from ItemLocation AS IL,[Order] AS O
Where IL.ItemID = O.ItemID
and QuantityOrdered >= 200 and Quantity <= 40
order by ItemID desc