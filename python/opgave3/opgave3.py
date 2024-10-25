import csv
import json
import os
import re

customers = []
invalid_customers = []

def validate_customer(customer: dict) -> bool:
    valid_customer = {}
    name_pattern = r'[\w\'\-\s]+'
    email_pattern = r'\w+[\w\.]+\w+@\w+\.[A-Za-z]+'
    try:
        valid_customer['customer_id'] = int(customer.get('customer_id'))
        valid_customer['purchase_amount'] = float(customer.get('purchase_amount'))

        name_match = re.findall(name_pattern, customer.get('name'))
        valid_customer['name'] = name_match[0]

        email_match = re.findall(email_pattern, customer.get('email'))
        valid_customer['email'] = email_match[0]

    except:
        return None
    
    
    return valid_customer
    



def add_customer(customer):
    customers.append(customer)

def add_invalid_customer(i, customer: dict):
    invalid_customers.append(f'line {i+1}: {json.dumps(customer)}')

cwd = os.getcwd()

with open(os.path.join(cwd, 'opgave3', 'source_data.csv'), newline='') as csvfile:
    spamreader = csv.DictReader(csvfile)

    for i, row in enumerate(spamreader):
        if i > 50: break

        valid_customer = validate_customer(row)

        if valid_customer:
            add_customer(valid_customer)
        else:
            add_invalid_customer(i, row)




# print(customers)
# print('')
# print(invalid_customers)

with open('valid_customers.json', 'w') as out:
    json.dump(customers, out, indent=3)

with open('invalid_customers.json', 'w') as out:
    json.dump(invalid_customers, out, indent=3)