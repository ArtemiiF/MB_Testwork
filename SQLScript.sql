using [prod]

select P."Name" as N'Название продукта', C."Name" as N'Название категории' from Products as P
left join ProductCategories as PC on P.Id = PC.ProductId
left join Categories as C ON PC.CategoryId = C.Id;