
```mermaid
erDiagram
    LAND-LLC }|..|{ RENTAL-CONTRACT : offers
    LAND-LLC ||--o{ SERVICE-LLC : places
    LAND-LLC ||--o{ IMPROVEMENTS : "liable for"
    RENTAL-CONTRACT ||--o{ SERVICE-LLC : receives
    IMPROVEMENTS ||--|{ SERVICE-LLC : covers
    SERVICE-LLC ||--|{ ORDER-ITEM : includes
    PRODUCT-CATEGORY ||--|{ PRODUCT : contains
    PRODUCT ||--o{ ORDER-ITEM : "ordered in"
```
