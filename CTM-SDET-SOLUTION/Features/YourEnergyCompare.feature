Feature: YourEnergyCompare
	


@Features
Scenario: ValidateGasAndElectricity
Given I have set Your Supplier Page Gas&ElectricityTab & YesCheckBox same supplier & Yes, I have my bill Tab 
| PostCode | SupplierButtons |
| PE2 6YS  | EDF Energy      |

And I have set Your Energy Page Electricity section with table information
| ElectricityTariff   | Economy7Meter | Payment              | HeatingSource | kWh | Duration |
| Standard (Variable) | No            | Monthly Direct Debit | No            | 900 | Annually |

And I have set Your Energy Page Gas section with table information 
 | ElectricityTariff   | Payment              | HeatingSource | kWh | Duration |
 | Standard (Variable) | Monthly Direct Debit | No            | 900 | Annually |

 When I set Your Preferences page with table information, checked all checkbox & click GoToPrices button
 | Tariffs | PaymentType | EmailAddress | 

 Then I am on Your Results page with message "<Your Results>" displayed

 