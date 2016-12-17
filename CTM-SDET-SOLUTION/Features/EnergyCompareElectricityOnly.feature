Feature: EnergyCompareElectricityOnly
	

@Features
Scenario: EnergyComparisonJourney_ElectricityOnly
Given I have set Your Supplier Page ElectricityTab & Yes, I have no bill Tab 
| PostCode | SupplierButtons |
| PE2 6YS  | EDF Energy      |

And Your Energy Page Electricity Only I don't know checkbox ticked
And I have set Your Energy Page Electricity only section with table information
| HomeSize     | NumberOfPeople | sourceOfHeating | Temperature | Insulation | cookingEnergySource | timesAtHome      |
| 1-2 Bedrooms | 3-4 Occupants  | Gas heating     | Temperate   | Airtight   | Electricity         | Most of the time |


 When I set Your Preferences page with table information, checked all checkbox & click GoToPrices button
 | Tariffs      | PaymentType       | EmailAddress      |
 | Fixed tariff | All payment types | sam@sam-kings.com |
 Then I am on Your Results page with message "<Your Results>" displayed
