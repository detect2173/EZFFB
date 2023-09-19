import csv

def process_csv_file(file_path):
    # Initialize an empty list to hold the processed rows
    processed_rows = []

    # Open the CSV file for reading
    with open(file_path, 'r') as csvfile:
        # Create a CSV reader object
        csvreader = csv.reader(csvfile)

        # Skip the header row
        next(csvreader, None)

        # Loop through each row in the CSV
        for row in csvreader:
            # Extract the columns we're interested in
            arrival_dt = row[0]  # ArrivalDt = DOE
            dob = row[1]  # DoB = DOB
            student_lname = row[2].replace(" ", "")  # StudentLName = Lastname, remove whitespaces
            student_fname = row[3]  # StudentFName = Firstname
            student_id = row[4]  # StudentId = StudentID

            # Generate email address
            email = f"{student_lname.lower()}.{student_fname.lower()}@live.jobcorps.org"

            # Create a dictionary with these values
            processed_row = {
                'DOE': arrival_dt,
                'DOB': dob,
                'Lastname': student_lname,
                'Firstname': student_fname,
                'StudentID': student_id,
                'Email': email,
                'Trade': 'CPP',      # Default value for Trade
                'Size': 'U/K',       # Default value for Size
                'Incentive': 'Blue'  # Default value for Incentive
            }

            # Add this dictionary to our list of processed rows
            processed_rows.append(processed_row)

    return processed_rows  # For now, just returning the processed rows
