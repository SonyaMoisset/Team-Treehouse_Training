require './contacts'

class AddressBook
    attr_reader :contacts

    def initialize
        @contacts = []
    end

    def find_by_name(name)
        results = []
        search = name.downcase
        contacts.each do |contact|
            results.push(contact) if contact.full_name.downcase.include?(search)
        end
        puts "Name search results (#{search})"
        results.each do |contact|
            puts contact.to_s('full_name')
            contact.print_phone_numbers
            contact.print_addresses
            puts "\n"
        end
    end

    def find_by_phone_number(_number)
        results = []
        search = number.gsub("-", "")
        contacts.each do |contact|
            contact.phone_numbers.each do |phone_number|
                if phone_number.number.gsub("-", "").include?(search)
                    results.push(contact) unless results.include?(contact)
                end
            end
        end
        print_results("Phone search results (#{search})", results)
    end

    def print_contact_list
        puts 'Contact List'
        contacts.each do |contact|
            puts contact.to_s('last_first')
        end
    end

    def print_results(search, results)
        puts search
        results.each do |contact|
            puts contact.to_s("full_name")
            contact.print_phone_numbers
            contact.print_addresses
            puts "\n"
        end
    end
end

address_book = AddressBook.new

jason = Contact.new
jason.first_name = 'Jason'
jason.last_name = 'Seifer'
jason.add_phone_number('Home', '123-456-7890')
jason.add_phone_number('Work', '456-789-0123')
jason.add_address('Home', '123 Main St.', '', 'Portland', 'OR', '12345')

nick = Contact.new
nick.first_name = 'Nick'
nick.last_name = 'Pettit'
nick.add_phone_number('Home', '222-222-2222')
nick.add_address('Home', '222 Two Lane', '', 'Portland', 'OR', '12345')

address_book.contacts.push(jason)
address_book.contacts.push(nick)

address_book.print_contact_list

address_book.find_by_name('e')
address_book.find_by_phone_number("2")
