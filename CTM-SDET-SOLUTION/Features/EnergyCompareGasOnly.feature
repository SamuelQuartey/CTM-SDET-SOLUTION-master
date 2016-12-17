Feature: EnergyCompareGasOnly
	



@Features
Scenario: EnergyComparisonJourney_GasOnly
Given I have set Your Supplier Page table information, Gas Only Tab &  I have no bill Tab 
| PostCode | SupplierSelectDropDown |
| PE2 6YS  | EDF Energy             |

And I have set Your Energy Page Gas Only with table information 
 | Payment | Duration |
 | £500    | Annually |

 When I set Your Preferences page with table information, checked all checkbox & click GoToPrices button
 | Tariffs      | PaymentType          | EmailAddress      |
 | Fixed tariff | Monthly direct debit | sam@sam-kings.com |
 Then I am on Your Results page with message "<Your Results>" displayed