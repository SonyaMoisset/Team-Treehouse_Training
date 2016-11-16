class PhoneNumber
  attr_accessor :kind, :number

  def to_s
    "#{kind}: #{number}"
  end
end
