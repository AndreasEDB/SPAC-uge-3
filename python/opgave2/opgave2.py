import os
import re

line_start = r'\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}\s'
error_pattern = f'{line_start}ERROR.+'
warning_pattern = f'{line_start}WARNING.+'

for file in ['error.txt', 'warning.txt']:
    try:
        os.unlink(file)
    except:
        pass

with open('app_log.txt') as log_in:
    with open('error.txt', 'w') as error_out:
        with open('warning.txt', 'w') as warning_out:
            for line in log_in.readlines():
                if re.match(error_pattern, line) != None:
                    error_out.write(line)
                if re.match(warning_pattern, line) != None:
                    warning_out.write(line)