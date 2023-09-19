import os
import psycopg2

def get_connection():
    # Retrieve environment variables for database credentials
    username = os.environ.get("DB_USERNAME")
    password = os.environ.get("DB_PASSWORD")

    # Create the connection string
    connection_string = f"host=localhost user={username} password={password} dbname=postgres"

    # Return a new psycopg2 connection object
    return psycopg2.connect(connection_string)

def fetch_roster_data():
    conn = get_connection()
    cursor = conn.cursor()

    # Execute SQL query
    cursor.execute("SELECT * FROM roster.roster")

    # Fetch data and close the connection
    data = cursor.fetchall()
    conn.close()

    return data
