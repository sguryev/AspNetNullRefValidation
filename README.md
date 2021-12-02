# AspNetNullRefValidation
Sanbox for reproducing the issue with the nullable ref validation for GET params

### Expected
Both `/test/base` and `/test/own` are expected to return 400 instead for missing string query paramter.

### Actual
`/test/base` reutns 200
