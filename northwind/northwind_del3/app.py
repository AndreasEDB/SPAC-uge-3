import os 
import django
import pandas as pd
import matplotlib.pyplot as plt

os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'northwind.settings')
django.setup()

from db import models

df = pd.DataFrame(list(models.Orders.objects.all().values()))

orders_by_country = df.groupby('shipcountry').size().reset_index(name='orders')

# print(orders_by_country)

# orders_by_country.plot()

plt.subplot(1, 3, 1)
plt.bar(orders_by_country['shipcountry'], orders_by_country['orders'], color='skyblue')
plt.xlabel('Land')
plt.ylabel('Antal ordrer')
plt.title('Antal ordrer pr. land')
plt.xticks(rotation=45)

plt.subplot(1, 3, 2)
plt.pie(orders_by_country['orders'], labels=orders_by_country['shipcountry'], autopct='%1.1f%%', startangle=140)
plt.title('Ordrefordeling pr. land')

plt.subplot(1, 3, 3)
plt.scatter(orders_by_country['shipcountry'], orders_by_country['orders'], color='purple')
plt.xlabel('Land')
plt.ylabel('Antal ordrer')
plt.title('Antal ordrer pr. land')

plt.tight_layout()

plt.show()