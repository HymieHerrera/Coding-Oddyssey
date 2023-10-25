class EventScheduler:

    def __init__(self):
        self.events = {}

    def add_event(self, hour, event):
        if hour in self.events:
            print(f"An event already exists for hour {hour}. Use the Edit option to change it.")
        else:
            self.events[hour] = event


    def delete_event(self, hour):
        if hour in self.events:
            del self.events[hour]
            print(f"Deleted event for hour {hour}.")
        else:
            print(f"No event found for hour {hour}.")

    def edit_event(self, hour, new_event):
        if hour in self.events:
            self.events[hour] = new_event
            print(f"Event for hour {hour} updated.")
        else:
            print(f"No event found for hour {hour}.")

    def view_events(self):
        for hour, event in sorted(self.events.items()):
            print(f"{hour}:00 - {event}")


def main():
    scheduler = EventScheduler()
    while True:
        print("\n________Event Scheduler________\n")
        print("1. Add event")
        print("2. Edit event")
        print("3. Delete event")
        print("4. View events")
        print("5. Quit")

        choice = input("Enter your choice: ")

        if choice == "1":
            hour = int(input("Enter the hour (0-23): "))
            if 0 <= hour <= 23:
                event = input("Enter the event description: ")
                scheduler.add_event(hour, event)
            else:
                print("Invalid hour. Please enter a value between 0 and 23.")

        elif choice == "2":
            hour = int(input("Enter the hour of the event to edit (0-23): "))
            if 0 <= hour <= 23:
                new_event = input("Enter the updated event description: ")
                scheduler.edit_event(hour, new_event)
            else:
                print("Invalid hour. Please enter a value between 0 and 23.")

        elif choice == "3":
            hour = int(input("Enter the hour of the event to delete (0-23): "))
            if 0 <= hour <= 23:
                scheduler.delete_event(hour)
            else:
                print("Invalid hour. Please enter a value between 0 and 23.")

        elif choice == "4":
            scheduler.view_events()

        elif choice == "5":
            print("Goodbye!")
            break

        else:
            print("Invalid choice. Please pick a number between 1 and 5.")

if __name__ == "__main__":
    main()
