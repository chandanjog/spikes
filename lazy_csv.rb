require 'csv'

def memstats
  puts `ps -o rss= -p $$`
end

memstats
#csv = CSV.open('points_offers_2014081680.csv', headers: true, encoding: 'utf-8', col_sep: ';', quote_char: "\x00", skip_blanks: true)
#puts csv.class
#puts csv.count
csv = CSV.read('points_offers_2014081680.csv', headers: true, encoding: 'utf-8', col_sep: ';', quote_char: "\x00", skip_blanks: true)
puts csv.class
puts csv.count
memstats
